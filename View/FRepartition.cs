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
    public partial class FRepartition : Form
    {
        public FRepartition()
        {
            InitializeComponent();
            this.load(new DaoColocataire().GetAll());
            this.load2(new DaoDepense().GetAll());
        }

        private void load(Colocataires lesColocataires)
        {
            tbNomTest.Clear();
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                tbNomTest.Text = lesColocataires.AfficherNom(4);
            }
        }
        private void load2(Depenses lesDepenses)
        {
            tbMontantTest.Clear();
            for (int i = 0; i < lesDepenses.Count(); i++)
            {
                tbMontantTest.Text = lesDepenses.AfficherMontant(4).ToString();
            }
        }
    }
}
