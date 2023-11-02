using Renci.SshNet;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace Pi_NAS_Manager
{
    public partial class SSH_Login : Form
    {
        public SSH_Login()
        {
            InitializeComponent();
        }

        public string sessionFilePath = "session.txt";

        private void SSH_Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(sessionFilePath))
            {
                StreamReader sr = File.OpenText(sessionFilePath);

                string lastSessionData = sr.ReadToEnd();
                sr.Close();

                User lastUser = JsonSerializer.Deserialize<User>(JsonDocument.Parse(lastSessionData));

                textBox_ip.Text = lastUser.IP;
                textBox_username.Text = lastUser.Username;
                textBox_password.Text = lastUser.Password;
                checkBox_remember.Checked = lastUser.Remember;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == String.Empty)
                    {
                        MessageBox.Show("Fill all textboxes.");
                        return;
                    }
                }
            }

            User currentUser = new User(textBox_ip.Text, textBox_username.Text, textBox_password.Text, checkBox_remember.Checked);
            SshClient sshClient = new SshClient(currentUser.IP, currentUser.Username, currentUser.Password);

            if (checkBox_remember.Checked)
            {
                StreamWriter sw = File.CreateText(sessionFilePath);

                sw.WriteLine(JsonSerializer.Serialize(currentUser));
                sw.Close();
            }
            else
                File.Delete(sessionFilePath);

            try
            {
                sshClient.Connect();

                Pi_NAS_Manager Pi_NAS_Manager = new Pi_NAS_Manager();

                Pi_NAS_Manager.currentUser = currentUser;
                Pi_NAS_Manager.sshClient = sshClient;

                Pi_NAS_Manager.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
