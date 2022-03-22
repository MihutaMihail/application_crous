using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CollectionLogs
    {
        List<Logs> lesLogs = new List<Logs>();

        public int Count()
        {
            int c = lesLogs.Count();
            return c;
        }

        public Logs this[int index]
        {
            get { return this.lesLogs[index]; }
        }

        public void AjouterLog(Logs nouveauLog)
        {
            lesLogs.Add(nouveauLog);
        }

    }
}
