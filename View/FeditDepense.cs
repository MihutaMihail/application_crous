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
            btnSelectFile.Click += btnSelectFile_Click;
            cbColocataire.TextChanged += cbColocataire_TextChanged;
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
                    this.tbSelectFile.Text = depense.Justificatif.ToString();
                    this.tbMontant.Text = depense.Montant.ToString();
                    this.tbReparti.Text = depense.Reparti.ToString();
                    this.tbColocataireId.Text = depense.IdColocataire.ToString();
                    this.Text = "Modification d'une dépense";
                    if (depense.Reparti == true) {
                        this.tbId.ReadOnly = true;
                        this.tbDate.ReadOnly = true;
                        this.tbTitre.ReadOnly = true;
                        this.tbSelectFile.ReadOnly = true;
                        this.tbMontant.ReadOnly = true;
                        this.tbReparti.ReadOnly = true;
                        this.tbColocataireId.ReadOnly = true;
                    }
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

        private void cbColocataire_TextChanged(object sender, EventArgs e)
        {
            Colocataire colocataire = new Colocataire();
            colocataire = (Colocataire)cbColocataire.SelectedItem;
            tbColocataireId.Text = Convert.ToString(colocataire.Id);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                string file = openFileDialog1.FileName;
                this.tbSelectFile.Text = file;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            switch (this.state)
            {
                case State.added:
                    items.Add(new Depense(0, Convert.ToDateTime(this.tbDate.Text), this.tbTitre.Text, this.tbSelectFile.Text, 
                        Convert.ToDouble(this.tbMontant.Text),Convert.ToInt32(tbColocataireId.Text),this.state));
                    break;
                case State.modified:
                    Depense depense = (Depense)items[this.position];
                    depense.Date = Convert.ToDateTime(this.tbDate.Text);
                    depense.Titre = this.tbTitre.Text;
                    depense.Justificatif = this.tbSelectFile.Text;
                    depense.Montant = Convert.ToDouble(this.tbMontant.Text);
                    depense.Reparti = Convert.ToBoolean(this.tbReparti.Text);
                    depense.IdColocataire = Convert.ToInt32(this.tbColocataireId.Text);
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
                cbColocataire.Items.Add(lesColocataires[i]);
            }
        }
    }
}
