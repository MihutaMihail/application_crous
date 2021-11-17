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

namespace View
{
    public partial class FApplicationCrous : Form
    {
        public FApplicationCrous()
        {
            InitializeComponent();
            this.Text = "Application Crous";
            btnColocataires.Click += btnColocataires_Click;
            btnRepartition.Click += btnRepartition_Click;
            btnDepenses.Click += btnDepenses_Click;
            DaoConnectionSingleton.SetStringConnection("root", "siojjr", "localhost", "crous");
        }

        private void btnRepartition_Click(object sender, EventArgs e)
        {
            FMiseEnRepartition r = new FMiseEnRepartition();
            r.Show();
        }

        private void btnColocataires_Click(object sender, EventArgs e)
        {
            FGestionColocataire gc = new FGestionColocataire();
            gc.Show();
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            FGestionDepense gd = new FGestionDepense();
            gd.Show();
        }
    }
}
