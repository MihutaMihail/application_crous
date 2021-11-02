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
            btnCalculerRepartition.Click += btnCalculerRepartition_Click;
            btnSolderPeriode.Click += btnSolderPeriode_Click;
            
        }

        private void btnSolderPeriode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette période a été soldé");
            FSolderPeriode sp = new FSolderPeriode();
            sp.ShowDialog();   
        }

        private void btnCalculerRepartition_Click(object sender, EventArgs e)
        {
            FCalculerRepartition cr = new FCalculerRepartition();
            cr.ShowDialog();
        }
    }
}
