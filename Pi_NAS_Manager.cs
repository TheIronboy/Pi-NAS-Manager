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

        private void Pi_NAS_Manager_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Username: " + currentUser.Username + Environment.NewLine + "Is Connected: " + sshClient.IsConnected.ToString());
        }
    }
}
