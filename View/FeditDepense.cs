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
        string identifiantLogs;
        string adresseIp;

        public FeditDepense(State state, ListBox.ObjectCollection items, int position, string identifiantLogs, string adresseIp)
        {
            InitializeComponent();
            btnValider.Click += btnValider_Click;
            btnSelectFile.Click += btnSelectFile_Click;
            btnAfficherImage.Click += btnAfficherImage_Click;
            cbColocataire.TextChanged += cbColocataire_TextChanged;
            tbMontant.KeyPress += tbMontant_KeyPressDecimalPoint;
            this.tbDate.MaxLength = 20;
            this.tbTitre.MaxLength = 20;
            this.tbMontant.MaxLength = 7;
            this.btnAfficherImage.Visible = false;
            this.state = state;
            this.items = items;
            this.position = position;
            this.identifiantLogs = identifiantLogs;
            this.adresseIp = adresseIp;
            this.AcceptButton = btnValider;
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
                    this.btnAfficherImage.Visible = true;
                    this.Text = "Modification d'une dépense";
                    if (depense.Reparti == true) {
                        this.tbDate.ReadOnly = true;
                        this.tbTitre.ReadOnly = true;
                        this.tbMontant.ReadOnly = true;
                        this.btnSelectFile.Text = "Afficher Image";
                        this.btnSelectFile.Click += btnAfficherImage_Click;
                        this.btnSelectFile.Click -= btnSelectFile_Click;
                        this.btnAfficherImage.Visible = false;
                        this.cbColocataire.Enabled = false;
                        this.lblDepenseReparti.Visible = true;
                        this.Size = new Size(408, 290);
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

        private void tbMontant_KeyPressDecimalPoint(object sender, KeyPressEventArgs e)
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
                        this.btnAfficherImage.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Vous ne pouvez pas mettre un fichier qui n'est pas une " +
                            "image (.png, .jgp, .jpeg)","Mauvais Format");
                    }
                }
            }
        }

        private bool CheckExtensionFile(string fileName)
        {
            var exclure = new[] {".php",".PHP",".exe",".EXE",".html",".HTML",".zip",".ZIP",".rar",".RAR",".pdf",".PDF"};

            if (exclure.Any(x => fileName.Contains(x)))
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
                    new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Ajout Nouvelle Dépense", State.logCreation);
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
                    new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Modifier Dépense", State.logCreation);
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
            string nomColocataireActuel = null;
            Comptes lesComptes = new DaoCompte().GetAll();
            for (int i = 0; i < lesComptes.Count(); i++)
            {
                if (lesComptes[i].Login == identifiantLogs)
                {
                    nomColocataireActuel = Chiffrement.DechiffrerBase64(lesComptes[i].NomColocataire);
                }
            }
            cbColocataire.Items.Clear();
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                if (nomColocataireActuel == lesColocataires[i].Nom)
                {
                    cbColocataire.Text = lesColocataires[i];
                }
            }
        }
    }
}
