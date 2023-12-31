﻿using System;
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
        public decimal APayer(int idColocataire)
        {
            decimal montantTotal = 0;
            for (int i = 0; i < lesDepenses.Count; i++)
            {
                if (lesDepenses[i].IdColocataire == idColocataire && lesDepenses[i].Reparti == false)
                {
                    montantTotal += lesDepenses[i].Montant;
                }
            }
            return montantTotal;
        }

        // Cette fonction calcule le montant total payé pour les colocataires qui habitent dans le même appartement
        // Le montant n'est pas divisé par le nombre de colocataires. Ceci est fait dans FMiseEnRepartition.
        public decimal AuraitDuPayer(Colocataires lesColocataires) {
            decimal montant = 0;
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                for (int j = 0; j < lesDepenses.Count(); j++)
                {
                    if (lesColocataires[i].Id == lesDepenses[j].IdColocataire && lesDepenses[j].Reparti == false)
                    {
                        montant += lesDepenses[j].Montant;
                    }
                }
            }
            return montant;
        }
    }
}
