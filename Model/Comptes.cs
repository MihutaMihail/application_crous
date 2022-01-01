using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comptes
    {
        List<Compte> lesComptes = new List<Compte>();

        public int Count()
        {
            int c = lesComptes.Count();
            return c;
        }

        public Compte this[int index]{
            get { return this.lesComptes[index]; }
        }

        public void AjouterCompte(Compte nouveauCompte)
        {
            this.lesComptes.Add(nouveauCompte);
        }
    }
}
