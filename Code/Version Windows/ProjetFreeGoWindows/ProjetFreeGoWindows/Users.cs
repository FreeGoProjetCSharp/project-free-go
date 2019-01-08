using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFreeGoWindows
{
    class Users
    {
        private List<Users> users = new List<Users>();
        private string username;
        private string mail;
        private string password;
        private int idFridge;

        public Users(string username, string mail, string password, int idFridge)
        {
            this.username = username;
            this.mail = mail;
            this.password = password;
            this.idFridge = idFridge;
        }
    }
}
