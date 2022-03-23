using System;
using System.IO;
using System.Security.AccessControl;
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
        string login;
        string password;
        string nomColocataire;
        string identifiantLogs;
        string adresseIp;

        public FCreationCompteColoc(string nomColocataire,string identifiantLogs, string adresseIp)
        {
            InitializeComponent();
            this.Text = "Compte colocataire";
            this.tbIdentifiant.MaxLength = 15;
            this.tbMdp.MaxLength = 15;
            this.nomColocataire = nomColocataire;
            this.identifiantLogs = identifiantLogs;
            this.adresseIp = adresseIp;
            btnValider.Click += btnValider_Click;
            this.AcceptButton = btnValider;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.login = tbIdentifiant.Text;
            this.password = tbMdp.Text;

            bool resultat = CaracteresDangereux(login, password);

            if (resultat == true)
            {
                string loginChiffrer = Chiffrement.ChiffrerBase64(this.login);
                string passwordChiffrer = Chiffrement.ChiffrerBase64(this.password);
                string nomColocataire = Chiffrement.ChiffrerBase64(this.nomColocataire);

                new DaoCompte().CreationCompte(loginChiffrer, passwordChiffrer, nomColocataire, State.compteCreation);
                new DaoLogs().CreationLog(identifiantLogs, adresseIp, DateTime.Now, "Création Compte", State.logCreation);

                this.Close();
            } else
            {
                MessageBox.Show("Les caractères spéciales sont interdites!","ATTENTION");
            }

        }

        private bool CaracteresDangereux(string loginVerify, string passwordVerify)
        {
            bool loginCheck = loginVerify.Any(ch => !Char.IsLetterOrDigit(ch));
            bool passwordCheck = passwordVerify.Any(ch => !Char.IsLetterOrDigit(ch));

            if (loginCheck == true || passwordCheck == true)
            {
                return false;
            }

            return true;
        }

    }
}
