using Pi_NAS_Manager.Properties;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_NAS_Manager
{
    public partial class Pi_NAS_Manager : Form
    {
        public User currentUser {  get; set; }

        public SshClient sshClient { get; set; }

        public Pi_NAS_Manager()
        {
            InitializeComponent();
        }

        public async void resourcesMonitor(SshClient sshClient)
        {
            while (true)
            {
                SshCommand CPULoad = sshClient.CreateCommand("mpstat 1 1 | awk '$12 ~ /[0-9.]+/ {usage = 100 - $12} END {print int(usage)}'");
                CPULoad.Execute();

                label_CPU.Text = CPULoad.Result.Replace("\n", String.Empty) + "%";
                progressBar_CPU.Value = Convert.ToInt32(CPULoad.Result);

                SshCommand RAMLoad = sshClient.CreateCommand("free | awk 'FNR == 2 {printf(\"%.0f\\n\", ($3/$2) * 100)}'\r\n");
                RAMLoad.Execute();

                label_RAM.Text = RAMLoad.Result.Replace("\n", String.Empty) + "%";
                progressBar_RAM.Value = Convert.ToInt32(RAMLoad.Result);

                await Task.Delay((int)numericUpDown_refresh.Value * 1000);
            }
        }

        private void Pi_NAS_Manager_Load(object sender, EventArgs e)
        {
            label_loggedUser.Text += currentUser.Username;

            resourcesMonitor(sshClient);
        }
    }
}
