using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Colocataires
    {
        List<Colocataire> lesColocataires = new List<Colocataire>();

        public int Count() {
            int c = lesColocataires.Count();
            return c;
        }

        public Colocataire this[int index]
        {
            get { return this.lesColocataires[index]; }
        }


        public void AjouterColocataire(Colocataire nouveauColocataire)
        {
            lesColocataires.Add(nouveauColocataire);
        }

        public void SupprimerColocataire(Colocataire colocataire)
        {
            lesColocataires.Remove(colocataire);
        }

        public string AfficherNom(int index)
        {
            string s = "";
            for (int i = 0; i < lesColocataires.Count; i++)
            {
                if (lesColocataires[i].Id == index) {
                    s = lesColocataires[i].Nom;
                }
            }
            return s;
        }
    }
}
