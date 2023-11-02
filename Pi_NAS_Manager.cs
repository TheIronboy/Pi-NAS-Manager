using Pi_NAS_Manager.Properties;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_NAS_Manager
{
    public partial class Pi_NAS_Manager : Form
    {
        public User currentUser { get; set; }

        public SshClient sshClient { get; set; }

        public Pi_NAS_Manager()
        {
            InitializeComponent();
        }

        private void Pi_NAS_Manager_Load(object sender, EventArgs e)
        {
            label_loggedUser.Text += currentUser.Username;

            SshCommand CPULoadCommand = sshClient.CreateCommand("top -n 1 -b | grep '%Cpu(s)' | awk '{printf \"%d\\n\", 100 - $8}'");
            SshCommand CPUTempCommand = sshClient.CreateCommand("vcgencmd measure_temp | sed 's/temp=//'");
            SshCommand RAMLoadCommand = sshClient.CreateCommand("free | awk 'FNR == 2 {printf(\"%.0f\\n\", ($3/$2) * 100)}'");

            Task.Run(async() =>
            {
                while (true)
                {
                    CPULoadCommand.Execute();
                    int CPULoad = Convert.ToInt32(CPULoadCommand.Result);

                    CPUTempCommand.Execute();
                    string CPUTemp = CPUTempCommand.Result;

                    RAMLoadCommand.Execute();
                    int RAMLoad = Convert.ToInt32(RAMLoadCommand.Result);

                    Invoke((Action)(() =>
                    {
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
    }
}
