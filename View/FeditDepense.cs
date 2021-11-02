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
using Dao;

namespace View
{
    public partial class FeditDepense : Form
    {
        State state;
        ListBox.ObjectCollection items;
        int position;

        public FeditDepense(State state, ListBox.ObjectCollection items, int position)
        {
            InitializeComponent();
            btnValider.Click += btnValider_Click;
            this.state = state;
            this.items = items;
            this.position = position;
            this.load(new DaoColocataire().GetAll());
            switch (state)
            {
                case State.added:
                    this.Text = "Ajout d'une dépense";
                    break;
                case State.modified:
                    Depense depense = (Depense)items[position];
                    this.tbId.Text = depense.Id.ToString();
                    this.tbDate.Text = depense.Date.ToString();
                    this.tbTitre.Text = depense.Titre.ToString();
                    this.tbJustificatif.Text = depense.Justificatif.ToString();
                    this.tbMontant.Text = depense.Montant.ToString();
                    this.tbReparti.Text = depense.Reparti.ToString();
                    this.cbColocataire.Text = depense.IdColocataire.ToString();
                    this.Text = "Modification d'une dépense";
                    break;
                case State.deleted:
                    this.Text = "Suppresion d'une dépense";
                    break;
                case State.unChanged:
                    this.Text = "Consultation d'une dépense";
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
                    items.Add(new Depense(0, Convert.ToDateTime(this.tbDate.Text), this.tbTitre.Text, this.tbJustificatif.Text, 
                        Convert.ToInt32(this.tbMontant.Text),Convert.ToInt32(cbColocataire.Text),this.state));
                    break;
                case State.modified:
                    Depense depense = (Depense)items[this.position];
                    depense.Date = Convert.ToDateTime(this.tbDate.Text);
                    depense.Titre = this.tbTitre.Text;
                    depense.Justificatif = this.tbJustificatif.Text;
                    depense.Montant = Convert.ToDecimal(this.tbMontant.Text);
                    depense.Reparti = Convert.ToBoolean(this.tbReparti.Text);
                    depense.IdColocataire = Convert.ToInt32(this.cbColocataire.Text);
                    depense.State = this.state;
                    items[this.position] = depense;
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
        private void load(Colocataires lesColocataires)
        {
            cbColocataire.Items.Clear();
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                cbColocataire.Items.Add(lesColocataires[i].Id);
            }
        }
    }
}
