using Renci.SshNet;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace Pi_NAS_Manager
{
    public partial class SSH_Login : Form
    {
        public string sessionFilePath = "session.txt";

        public SSH_Login()
        {
            InitializeComponent();
        }

        private void SSH_Login_Load(object sender, EventArgs e)
        {
            //legge file session al load del form (se esiste), lo deserializza (in user) e inserisce i dati nel form.

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
            //controlla che tutti i textbox nel form siano riempiti.

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Fill all textboxes.", "ERROR");
                        return;
                    }
                }
            }

            //definisce l'oggetto utente e sshclient con le variabili inserite nel form

            User currentUser = new User(textBox_ip.Text, textBox_username.Text, textBox_password.Text, checkBox_remember.Checked);
            SshClient sshClient = new SshClient(currentUser.IP, currentUser.Username, currentUser.Password);

            //controlla se il checkbox nell form è checked, e se lo è, crea un file .json con all'interno le informazioni della sessione

            if (checkBox_remember.Checked)
            {
                StreamWriter sw = File.CreateText(sessionFilePath);

                sw.WriteLine(JsonSerializer.Serialize(currentUser));
                sw.Close();
            }
            else
                File.Delete(sessionFilePath);

            //tenta connessione al server, se fallita, lascia messagebox con messaggio errore.

            try
            {
                sshClient.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }

            //inizializza il nuovo form passando la connessione al server, e attende la sua chiusura

            Pi_NAS_Manager Pi_NAS_Manager = new Pi_NAS_Manager();
            Pi_NAS_Manager.sshClient = sshClient;

            Hide();
            Pi_NAS_Manager.ShowDialog();

            //una volta chiuso il form, disconnette dal server (se ancora connesso) e chiude tutto.

            if (sshClient.IsConnected)
            {
                sshClient.Disconnect();
            }

            Close();
        }
    }
}
