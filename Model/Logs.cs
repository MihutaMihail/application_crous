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
    }
}
