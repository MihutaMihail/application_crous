using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;

namespace View
{
    public partial class FMiseEnRepartition : Form
    {
        string identifiantLogs;
        string adresseIp;

        public FMiseEnRepartition(string identifiantLogs, string adresseIp)
        {
            InitializeComponent();
            btnSolderPeriode.Click += btnSolderPeriode_Click;
            this.identifiantLogs = identifiantLogs;
            this.adresseIp = adresseIp;
            this.Text = "Calculer la répartition"; 
            this.load(new DaoColocataire().GetAll(), new DaoDepense().GetAll());
            this.dataGridView1.Columns["Nom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["APaye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["AuraitDuPayer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["SoldesARegler"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns) {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void load(Colocataires lesColocataires, Depenses lesDepenses)
        {
            Colocataires colocatairesMemeAppartement = trouverAppartement(lesColocataires);
            int numAppartment = numeroAppartement(lesColocataires);

            int nombreColocataires = colocatairesMemeAppartement.Count();
            for (int i = 0; i < colocatairesMemeAppartement.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[i].Cells[0].Value = colocatairesMemeAppartement[i].Nom;
            }
            for (int i = 0; i < colocatairesMemeAppartement.Count(); i++)
            {
                int index = colocatairesMemeAppartement.GetIndex(i);
                dataGridView1.Rows[i].Cells[1].Value = lesDepenses.APayer(index).ToString();
            }
            for (int i = 0; i < colocatairesMemeAppartement.Count(); i++)
            {
                decimal valeur = Convert.ToDecimal(lesDepenses.AuraitDuPayer(colocatairesMemeAppartement)) / nombreColocataires;
                dataGridView1.Rows[i].Cells[2].Value = Math.Round(valeur,2);
            }
            for (int i = 0; i < colocatairesMemeAppartement.Count(); i++)
            {
                decimal valeur = Convert.ToDecimal(lesDepenses.AuraitDuPayer(colocatairesMemeAppartement)) / nombreColocataires;
                int index = colocatairesMemeAppartement.GetIndex(i);
                dataGridView1.Rows[i].Cells[3].Value = Math.Round(valeur - lesDepenses.APayer(index),2);
            }
        }

        private Colocataires trouverAppartement(Colocataires lesColocataires)
        {
            int numAppartement = -333;
            string nomColocataireActuel = null;
            Colocataires colocatairesMemeAppartement = new Colocataires();
            Comptes lesComptes = new DaoCompte().GetAll();

            for (int i = 0; i < lesComptes.Count(); i++)
            {
                if (lesComptes[i].Login == identifiantLogs)
                {
                    nomColocataireActuel = Chiffrement.DechiffrerBase64(lesComptes[i].NomColocataire);
                }
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                if (nomColocataireActuel == lesColocataires[i].Nom)
                {
                    numAppartement = lesColocataires[i].Appartement;
                    this.txtAppartement.Text = Convert.ToString(numAppartement);
                }
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                if (lesColocataires[i].Appartement == numAppartement)
                {
                    colocatairesMemeAppartement.AjouterColocataire(lesColocataires[i]);
                }
            }
            return colocatairesMemeAppartement;
        }

        private int numeroAppartement(Colocataires lesColocataires)
        {
            int numAppartement = -333;
            string nomColocataireActuel = null;
            Colocataires colocatairesMemeAppartement = new Colocataires();
            Comptes lesComptes = new DaoCompte().GetAll();

            for (int i = 0; i < lesComptes.Count(); i++)
            {
                if (lesComptes[i].Login == identifiantLogs)
                {
                    nomColocataireActuel = Chiffrement.DechiffrerBase64(lesComptes[i].NomColocataire);
                }
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                if (nomColocataireActuel == lesColocataires[i].Nom)
                {
                    numAppartement = lesColocataires[i].Appartement;
                }
            }
            return numAppartement;
        }

        private void btnSolderPeriode_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir solder une période ?", "ATTENTION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Solder une période", State.logCreation);
                this.Hide();
                MessageBox.Show("Cette période a été soldé !");
                FSolderUnePeriode s = new FSolderUnePeriode();
                s.ShowDialog();
            }
        }
    }
}
