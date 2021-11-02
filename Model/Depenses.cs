using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Depenses
    {
        List<Depense> lesDepenses = new List<Depense>();

        public int Count()
        {
            int c = lesDepenses.Count();
            return c;
        }

        public Depense this[int index]
        {
            get { return this.lesDepenses[index]; }
        }

        public void AjouterDepense(Depense nouvelleDepense)
        {
            lesDepenses.Add(nouvelleDepense);
        }

        public void SupprimerDepense(Depense depense)
        {
            lesDepenses.Remove(depense);
        }
        public decimal AfficherMontant(int montant)
        {
            decimal s = 0;
            for (int i = 0; i < lesDepenses.Count; i++)
            {
                if (lesDepenses[i].Id == montant)
                {
                    s = lesDepenses[i].Montant;
                }
            }
            return s;
        }
    }
}
