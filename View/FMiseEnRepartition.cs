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
        public FMiseEnRepartition()
        {
            InitializeComponent();
            btnSolderPeriode.Click += btnSolderPeriode_Click;
            this.Text = "Calculer la répartition"; 
            this.load(new DaoColocataire().GetAll(), new DaoDepense().GetAll());
            this.dataGridView1.Columns["Nom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["APaye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["AuraitDuPayer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["SoldesARegler"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns) {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void load(Colocataires lesColocataires, Depenses lesDepenses)
        {
            int nombreColocataires = lesColocataires.Count();
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[i].Cells[0].Value = lesColocataires[i].Nom;
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                int index = lesColocataires.GetIndex(i);
                dataGridView1.Rows[i].Cells[1].Value = lesDepenses.APayer(index).ToString();
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                decimal valeur = Convert.ToInt32(lesDepenses.AuraitDuPayer()) / nombreColocataires;
                dataGridView1.Rows[i].Cells[2].Value = valeur.ToString();
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                decimal valeur = Convert.ToDecimal(lesDepenses.AuraitDuPayer()) / nombreColocataires;
                int index = lesColocataires.GetIndex(i);
                dataGridView1.Rows[i].Cells[3].Value = valeur - lesDepenses.APayer(index);
            }
        }

        private void btnSolderPeriode_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir solder une période ?", "ATTENTION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("Cette période a été soldé !");
                FSolderUnePeriode s = new FSolderUnePeriode();
                s.ShowDialog();
            }
        }
    }
}
