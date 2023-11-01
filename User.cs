using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_NAS_Manager
{
    public class User
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
    }
}
