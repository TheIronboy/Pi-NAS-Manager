using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pi_NAS_Manager
{
    public partial class SSH_Login : Form
    {
        public SSH_Login()
        {
            InitializeComponent();
        }

        private void SSH_Login_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            User user = new User(textBox_ip.Text, textBox_username.Text, textBox_password.Text, checkBox_remember.Checked);

            SshClient sshClient = new SshClient(user.IP, user.Username, user.Password);
            sshClient.Connect();

            MessageBox.Show(user.toJSON() + Environment.NewLine + "IS CONNECTED: " + sshClient.IsConnected.ToString());
        }
    }
}
