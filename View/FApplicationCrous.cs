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
        string identifiantLogs;
        string identifiantAfficher;
        string adresseIp;

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
            identifiantAfficher = c.identifiantLogs;
            identifiantLogs = Chiffrement.ChiffrerBase64(c.identifiantLogs);
            adresseIp = IpAddress.AdresseIp();

            if (this.stateConnection == StateConnection.connectedAdmin)
            {
                lbConnexion.Text = "Mode Admin";
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Connexion Admin", State.logCreation);
            }
            else if (this.stateConnection == StateConnection.connectedUser)
            {
                string nomColocataireAfficher = null;
                Comptes lesComptes = new DaoCompte().GetAll();
                for (int i = 0; i < lesComptes.Count(); i++)
                {
                    if (identifiantAfficher == Chiffrement.DechiffrerBase64(lesComptes[i].Login))
                    {
                        nomColocataireAfficher = Chiffrement.DechiffrerBase64(lesComptes[i].NomColocataire);
                    }
                }
                lbConnexion.Text = "Bonjour, " + nomColocataireAfficher;
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Connexion Colocataire", State.logCreation);
            }
            else if (this.stateConnection == StateConnection.error)
            {
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Erreur Connexion", State.logCreation);
                MessageBox.Show("L'un de vos identifiants est incorrecte","ATTENTION");
            }
        }

        private void btnColocataires_Click(object sender, EventArgs e)
        {
            adresseIp = IpAddress.AdresseIp();
            if (stateConnection == StateConnection.connectedAdmin)
            {
                FGestionColocataire gc = new FGestionColocataire(identifiantLogs,adresseIp);
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Clique sur 'Gestion des colocataires'", State.logCreation);
                gc.Show();
            } else {
                MessageBox.Show("Il faut être connecter en tant que ADMIN pour y accèder","ATTENTION");
            }
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            adresseIp = IpAddress.AdresseIp();
            if (stateConnection == StateConnection.connectedAdmin || stateConnection == StateConnection.connectedUser)
            {
                FGestionDepense gd = new FGestionDepense(identifiantLogs, adresseIp);
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Clique sur 'Gestion des dépenses'", State.logCreation);
                gd.Show();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecter","ATTENTION");
            }    
        }

        private void btnRepartition_Click(object sender, EventArgs e)
        {
            adresseIp = IpAddress.AdresseIp();
            if (stateConnection == StateConnection.connectedAdmin || stateConnection == StateConnection.connectedUser)
            {
                FMiseEnRepartition d = new FMiseEnRepartition(identifiantLogs, adresseIp);
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Clique sur 'Mise en répartition'", State.logCreation);
                d.Show();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecter","ATTENTION");
            }    
        }
    }
}
