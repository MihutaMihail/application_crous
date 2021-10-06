using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Depenses
    {
        List<Depense> lesDepenses = new List<Depense>();

        public void AjouterDepense(Depense nouvelleDepense)
        {
            lesDepenses.Add(nouvelleDepense);
        }

        public void SupprimerDepense(int index)
        {
            lesDepenses.RemoveAt(index);
        }

    }
}
