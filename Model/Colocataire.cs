using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Colocataire
    {
        private string nom;
        private string prenom;
        private int age;
        private int numTel;
        private string adresseMail;

        public Colocataire(string nom, string prenom, int age, int numTel, string adresseMail)
        {
            this.nom = nom;
            this.prenom = nom;
            this.age = age;
            this.numTel = numTel;
            this.adresseMail = adresseMail;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int NumTel
        {
            get { return this.numTel; }
            set { this.numTel = value; }
        }

        public string AdresseMail
        {
            get { return this.adresseMail; }
            set { this.adresseMail = value; }
        }

        public override string ToString()
        {
            string s = string.Format("Un colocataire nommé {0} {1} agé de {2} an(s). " +
                "Son numéro de téléphone {3} et son adresse mail ''{4}''", 
                this.nom, this.prenom, this.age,this.numTel,this.adresseMail);
            return s;
        }

    }
}
