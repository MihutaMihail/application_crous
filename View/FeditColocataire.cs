using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FeditColocataire : Form
    {
        State state;
        ListBox.ObjectCollection items;
        int position;

        public FeditColocataire(State state, ListBox.ObjectCollection items, int position)
        {
            InitializeComponent();
            btnValider.Click += btnValider_Click;
            this.state = state;
            this.items = items;
            this.position = position;
            switch (state)
            {
                case State.added:
                    this.Text = "Ajout d'un colocataire";
                    break;
                case State.modified:
                    Colocataire colocataire = (Colocataire)items[position];
                    this.tbIdColocataire.Text = colocataire.Id.ToString();
                    this.tbNom.Text = colocataire.Nom.ToString();
                    this.tbPrenom.Text = colocataire.Prenom.ToString();
                    this.tbAge.Text = colocataire.Age.ToString();
                    this.tbTel.Text = colocataire.NumTel.ToString();
                    this.tbMail.Text = colocataire.AdresseMail.ToString();
                    this.Text = "Modification d'un colocataire";
                    break;
                case State.deleted:
                    this.Text = "Suppresion d'un colocataire";
                    break;
                case State.unChanged:
                    this.Text = "Consultation d'un colocataire";
                    break;
                default:
                    break;        
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            switch (this.state)
            {
                case State.added:
                    Colocataire nouveauColocataire = new Colocataire(0, this.tbNom.Text, this.tbPrenom.Text, Convert.ToInt32(this.tbAge.Text),
                    Convert.ToInt32(this.tbTel.Text), this.tbMail.Text, this.state);
                    items.Add(nouveauColocataire);
                    break;
                case State.modified:
                    Colocataire colocataire = (Colocataire)items[this.position];
                    colocataire.Id = Convert.ToInt32(this.tbIdColocataire.Text);
                    colocataire.Nom = this.tbNom.Text;
                    colocataire.Prenom = this.tbPrenom.Text;
                    colocataire.Age = Convert.ToInt32(this.tbAge.Text);
                    colocataire.NumTel = Convert.ToInt32(this.tbTel.Text);
                    colocataire.AdresseMail = this.tbMail.Text;
                    colocataire.State = this.state;
                    items[this.position] = colocataire;
                    break;
                case State.deleted:
                    break;
                case State.unChanged:
                    break;
                default:
                    break;
            }
            this.Close();
        }
    }
}
