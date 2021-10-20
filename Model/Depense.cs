using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Depense
    {
        private int id;
        private DateTime date;
        private string titre;
        private string justificatif;
        private decimal montant;
        private bool reparti;
        private int idColocataire;
        private State state;

        public Depense(int id,DateTime date, string titre, string justificatif, decimal montant, bool reparti,int idColocataire,State state)
        {
            this.id = id;
            this.date = date;
            this.titre = titre;
            this.justificatif = justificatif;
            this.montant = montant;
            this.reparti = reparti;
            this.idColocataire = idColocataire;
            this.state = state;
        }
        public Depense(int id, DateTime date, string titre, string justificatif, decimal montant,int idColocataire, State state)
        {
            this.id = id;
            this.date = date;
            this.titre = titre;
            this.justificatif = justificatif;
            this.montant = montant;
            this.reparti = false;
            this.idColocataire = idColocataire;
            this.state = state;
        }

        public int IdColocataire
        {
            get { return this.idColocataire; }
            set { this.idColocataire = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public void Remove()
        {
            this.state = State.deleted;
        }

        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Titre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }

        public string Justificatif
        {
            get { return this.justificatif; }
            set { this.justificatif = value; }
        }

        public decimal Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }

        public bool Reparti
        {
            get { return this.reparti; }
            set { this.reparti = value; }
        }
        
        public override string ToString()
        {
            string s = string.Format("{0} coûte {1} € réalisé en {2}",this.titre,this.montant,this.date);
            return s;
        }

    }
}
