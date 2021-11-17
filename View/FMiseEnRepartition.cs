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
    public partial class FMiseEnRepartition : Form
    {
        public FMiseEnRepartition()
        {
            InitializeComponent();
            btnSolderPeriode.Click += btnSolderPeriode_Click;
            this.Text = "Calculer la répartition";
            this.load(new DaoColocataire().GetAll(), new DaoDepense().GetAll());
        }

        private void load(Colocataires lesColocataires, Depenses lesDepenses)
        {
            int index1 = lesColocataires.GetIndex(0);
            lblColoc1.Text = lesColocataires.GetNom(0);
            tbAPayeColoc1.Text = lesDepenses.APayer(index1).ToString() + " €";
            tbAuraitPayerColoc1.Text = lesDepenses.AuraitDuPayer().ToString() + " €";
            tbSolderReglerColoc1.Text = lesDepenses.AuraitDuPayer() - lesDepenses.APayer(index1) + " €";

            int index2 = lesColocataires.GetIndex(1);
            lblColoc2.Text = lesColocataires.GetNom(1);
            tbAPayeColoc2.Text = lesDepenses.APayer(index2).ToString() + " €";
            tbAuraitPayerColoc2.Text = lesDepenses.AuraitDuPayer().ToString() + " €";
            tbSolderReglerColoc2.Text = lesDepenses.AuraitDuPayer() - lesDepenses.APayer(index2) + " €";

            int index3 = lesColocataires.GetIndex(2);
            lblColoc3.Text = lesColocataires.GetNom(2);
            tbAPayeColoc3.Text = lesDepenses.APayer(index3).ToString() + " €";
            tbAuraitPayerColoc3.Text = lesDepenses.AuraitDuPayer().ToString() + " €";
            tbSolderReglerColoc3.Text = lesDepenses.AuraitDuPayer() - lesDepenses.APayer(index3) + " €";

        }

        private void btnSolderPeriode_Click (object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir solder une période ?", "ATTENTION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("Cette période a été soldé !");
                FSolderPeriode sp = new FSolderPeriode();
                sp.ShowDialog();
            }
        }
    }
}
