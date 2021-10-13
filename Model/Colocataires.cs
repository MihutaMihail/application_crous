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

        public void AjouterColocataire(Colocataire nouveauColocataire)
        {
            lesColocataires.Add(nouveauColocataire);
        }

        public void SupprimerColocataire(int index)
        {
            lesColocataires.RemoveAt(index);
        }
    }
}
