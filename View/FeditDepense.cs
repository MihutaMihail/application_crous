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
            btnAfficherImage.Click += btnAfficherImage_Click;
            cbColocataire.TextChanged += cbColocataire_TextChanged;
            tbMontant.KeyPress += tbMontant_KeyPress;
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
                    this.tbDate.Text = depense.Date.ToString();
                    this.tbTitre.Text = depense.Titre.ToString();
                    this.tbSelectFile.Text = depense.Justificatif.ToString();
                    this.tbMontant.Text = depense.Montant.ToString();
                    this.Text = "Modification d'une dépense";
                    if (depense.Reparti == true) {
                        this.tbDate.ReadOnly = true;
                        this.tbTitre.ReadOnly = true;
                        this.tbMontant.ReadOnly = true;
                        this.btnSelectFile.Visible = false;
                        this.cbColocataire.Enabled = false;
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

        private void tbMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void btnAfficherImage_Click(object sender, EventArgs e)
        {
            FImage image = new FImage(this.tbSelectFile.Text);
            image.ShowDialog();
        }

        private void cbColocataire_TextChanged(object sender, EventArgs e)
        {
            Colocataire colocataire = new Colocataire();
            colocataire = (Colocataire)cbColocataire.SelectedItem;
            tbColocataireId.Text = Convert.ToString(colocataire.Id);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = openFileDialog1.FileName;

                    bool badExtension = CheckExtensionFile(file);

                    if (badExtension == false)
                    {
                        this.tbSelectFile.Text = file;
                    }
                    else
                    {
                        MessageBox.Show("Le fichier choisi contient une extension qui est peut être dangereux!","ATTENTION");
                    }
                }
            }
        }

        private bool CheckExtensionFile(string fileName)
        {
            if (!fileName.Contains(".png") || !fileName.Contains(".jpg") || !fileName.Contains(".jpeg"))
            {
                return true;
            }
            return false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            switch (this.state)
            {
                case State.added:
                    items.Add(new Depense(0, Convert.ToDateTime(this.tbDate.Text), this.tbTitre.Text, this.tbSelectFile.Text, 
                        Convert.ToDecimal(this.tbMontant.Text),Convert.ToInt32(tbColocataireId.Text),this.state));
                    break;
                case State.modified:
                    Depense depense = (Depense)items[this.position];
                    depense.Date = Convert.ToDateTime(this.tbDate.Text);
                    depense.Titre = this.tbTitre.Text;
                    depense.Justificatif = this.tbSelectFile.Text;
                    depense.Montant = Convert.ToDecimal(this.tbMontant.Text);
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
