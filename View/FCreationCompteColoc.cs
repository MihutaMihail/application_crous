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
    public partial class FCreationCompteColoc : Form
    {
        public FCreationCompteColoc()
        {
            InitializeComponent();
            this.Text = "Compte colocataire";
            btnValider.Click += btnValider_Click;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = tbIdentifiant.Text;
            string password = tbMdp.Text;

            new DaoCompte().CreationCompte(login, password, State.compteCreation);

            Comptes lesComptes = new Comptes();
            lesComptes.AjouterCompte(new Compte(login,password));

            this.Close();
        }
    }
}
