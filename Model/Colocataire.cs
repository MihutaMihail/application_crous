using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Colocataire
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private int numTel;
        private string adresseMail;
        private State state;

        public Colocataire(int id, string nom, string prenom, int age, int numTel, string adresseMail, State state)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.numTel = numTel;
            this.adresseMail = adresseMail;
            this.state = state;
        }

        public void Remove()
        {
            this.state = State.deleted;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public State State
        {
            get { return this.state; }
            set { this.state = value; }
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
            string s = string.Format("Nom : {0} | Prénom : {1} | Age : {2} | Num° Tel : {3} | Mail : {4}", 
                this.nom, this.prenom, this.age,this.numTel,this.adresseMail);
            return s;
        }

    }
}
