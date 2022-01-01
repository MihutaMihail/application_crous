using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Compte
    {
        private string login;
        private string password;

        public Compte(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
