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
        public double APayer(int idColocataire)
        {
            double montantTotal = 0;
            for (int i = 0; i < lesDepenses.Count; i++)
            {
                if (lesDepenses[i].IdColocataire == idColocataire && lesDepenses[i].Reparti == false)
                {
                    montantTotal += lesDepenses[i].Montant;
                }
            }
            return montantTotal;
        }

        // Cette fonction calcule le montant total payé par tous les colocataires
        // Le montant va être divisé par le nombre de colocataire qui sont compris dans le calcul
        // Si 3 colocataires ont payé sauf 1, le montant va être divisé par 3 et pas par 4
        public double AuraitDuPayer() {
            double montant = 0;
            List<int> nombres = new List<int>();
            int nbColoc = 0;

            foreach (Depense d in lesDepenses) {         
                if (d.Reparti == false) {
                    montant += d.Montant;
                    nombres.Add(d.IdColocataire);
                }
            }
            nbColoc = nombres.Distinct().Count();
            return montant/nbColoc;
        }
    }
}
