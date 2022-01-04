using System;
using System.IO;
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
    public partial class FApplicationCrous : Form
    {
        StateConnection stateConnection;

        public FApplicationCrous(StateConnection stateConnection)
        {
            InitializeComponent();
            this.Text = "Application Crous";
            this.lbConnexion.Text = "Pas Connecter";
            this.stateConnection = stateConnection;
            btnColocataires.Click += btnColocataires_Click;
            btnRepartition.Click += btnRepartition_Click;
            btnDepenses.Click += btnDepenses_Click;
            btnConnexion.Click += btnConnexion_Click;
            DaoConnectionSingleton.SetStringConnection("root", "siojjr", "localhost", "crous");
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            FConnexion c = new FConnexion();
            c.ShowDialog();
            stateConnection = c.StateConnection;

            if (this.stateConnection == StateConnection.connectedAdmin)
            {
                lbConnexion.Text = "Mode Admin";
            }
            else if (this.stateConnection == StateConnection.connectedUser)
            {
                lbConnexion.Text = "Bonjour, Colocataire";
            }
            else if (this.stateConnection == StateConnection.error)
            {
                MessageBox.Show("L'un de vos identifiants est incorrecte","ATTENTION");
            }
        }

        private void btnColocataires_Click(object sender, EventArgs e)
        {
            if (stateConnection == StateConnection.connectedAdmin)
            {
                FGestionColocataire gc = new FGestionColocataire();
                gc.Show();
            } else {
                MessageBox.Show("Il faut être connecter en tant que ADMIN pour y accèder","ATTENTION");
            }
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            if (stateConnection == StateConnection.connectedAdmin || stateConnection == StateConnection.connectedUser)
            {
                FGestionDepense gd = new FGestionDepense();
                gd.Show();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecter","ATTENTION");
            }    
        }

        private void btnRepartition_Click(object sender, EventArgs e)
        {
            if (stateConnection == StateConnection.connectedAdmin || stateConnection == StateConnection.connectedUser)
            {
                FMiseEnRepartition d = new FMiseEnRepartition();
                d.Show();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecter","ATTENTION");
            }    
        }
    }
}
