using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Logs
    {
        private int id;
        private string identifiant;
        private DateTime dateLog;
        private string action;

        public Logs(int id, string identifiant, DateTime dateLog, string action)
        {
            this.id = id;
            this.identifiant = identifiant;
            this.dateLog = dateLog;
            this.action = action;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Identifiant
        {
            get { return this.identifiant; }
            set { this.identifiant = value; }
        }
        public DateTime DateLog
        {
            get { return this.dateLog; }
            set { this.dateLog = value; }
        }
        public string Action
        {
            get { return this.action; }
            set { this.action = value; }
        }
    }
}
