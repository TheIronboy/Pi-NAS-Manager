using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pi_NAS_Manager
{
    internal class User
    {
        public string IP { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool Remember { get; set; }

        public User(string ip, string username, string password, bool remember)
        {
            IP = ip;

            Username = username;
            Password = password;

            Remember = remember;
        }

        public string toJSON()
        {
            return JsonSerializer.Serialize(this);
        }

        public void setDataFromJSON()
        {
            //here man
        }
    }
}
