using Renci.SshNet;
using Renci.SshNet.Common;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_NAS_Manager
{
    public partial class Pi_NAS_Manager : Form
    {
        public SshClient sshClient;
        public ShellStream shellStream;

        public Pi_NAS_Manager()
        {
            InitializeComponent();
        }

        private void Pi_NAS_Manager_Load(object sender, EventArgs e)
        {
            //insertisce username della connessione attuale nel titolo del form e crea la stream per la shell console

            Text += sshClient.ConnectionInfo.Username;
            shellStream = sshClient.CreateShellStream("/usr/bin/bash", 80, 24, 800, 600, 1024);

            //avvia task asincrona per il monitoraggio delle varie risorse (lettura console shell inclusa), eseguendo i comandi ogni lasso di tempo determinato nel form

            Task.Run(async () =>
            {
                StreamReader shellStreamReader = new StreamReader(shellStream);

                SshCommand UpTimeCommand = sshClient.CreateCommand("uptime -p | sed 's/up //'");
                SshCommand CPULoadCommand = sshClient.CreateCommand("top -n 1 -b | grep '%Cpu(s)' | awk '{printf \"%d\\n\", 100 - $8}'");
                SshCommand CPUTempCommand = sshClient.CreateCommand("vcgencmd measure_temp | sed 's/temp=//'");
                SshCommand RAMLoadCommand = sshClient.CreateCommand("free | awk 'FNR == 2 {printf(\"%.0f\\n\", ($3/$2) * 100)}'");

                while (true)
                {
                    string line = shellStreamReader.ReadToEnd();

                    UpTimeCommand.Execute();
                    string UpTime = UpTimeCommand.Result;

                    CPULoadCommand.Execute();
                    int CPULoad = Convert.ToInt32(CPULoadCommand.Result);

                    CPUTempCommand.Execute();
                    string CPUTemp = CPUTempCommand.Result;

                    RAMLoadCommand.Execute();
                    int RAMLoad = Convert.ToInt32(RAMLoadCommand.Result);

                    Invoke((Action)(() =>
                    {
                        if (line != string.Empty)
                        {
                            if (richTextBox_consoleOutput.Text == string.Empty)
                                richTextBox_consoleOutput.Text += line + Environment.NewLine;
                            else
                                richTextBox_consoleOutput.Text += line;
                        }

                        label_uptime.Text = "System Uptime: " + UpTime;

                        label_CPU.Text = CPULoad + "%";
                        progressBar_CPU.Value = CPULoad;

                        label_CPUTemp.Text = CPUTemp;

                        label_RAM.Text = RAMLoad + "%";
                        progressBar_RAM.Value = RAMLoad;
                    }));

                    await Task.Delay((int)numericUpDown_refresh.Value * 1000);
                }
            });
        }

        private void button_poweroff_Click(object sender, EventArgs e)
        {
            //messagebox con bottoni risposta, che se positiva, crea comando e spegne il server

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "POWER OFF", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SshCommand PowerOFFCommand = sshClient.CreateCommand("sudo poweroff");
                    PowerOFFCommand.Execute();
                }
                catch (SshConnectionException)
                {
                    MessageBox.Show("Done.", "SUCCESS");
                    Close();
                }
            }
        }

        private void button_reboot_Click(object sender, EventArgs e)
        {
            //messagebox con bottoni risposta, che se positiva, crea comando e riavvia il server

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "REBOOT", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SshCommand RebootCommand = sshClient.CreateCommand("sudo reboot");
                    RebootCommand.Execute();
                }
                catch (SshConnectionException)
                {
                    MessageBox.Show("Done.", "SUCCESS");
                    Close();
                }
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            //disconnette dal server e chiude il form

            sshClient.Disconnect();

            MessageBox.Show("Done.", "SUCCESS");
            Close();
        }

        private void button_sendCommand_Click(object sender, EventArgs e)
        {
            //scrive il comando digitato nel textbox nella shellStream e lo esegue (e pulisce il comando dal textbox)

            shellStream.WriteLine(textBox_consoleInput.Text);
            textBox_consoleInput.Clear();
        }
    }
}
