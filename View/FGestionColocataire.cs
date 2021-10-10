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
    public partial class FGestionColocataire : Form
    {
        public FGestionColocataire()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FeditColocataire fEdit = new FeditColocataire(State.added, lbColocataires.Items, 0);
            fEdit.Show();
        }
    }
}
