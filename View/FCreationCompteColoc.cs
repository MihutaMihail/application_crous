﻿using System;
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

        public FCreationCompteColoc(string nomColocataire)
        {
            InitializeComponent();
            this.Text = "Compte colocataire";
            this.tbIdentifiant.MaxLength = 15;
            this.tbMdp.MaxLength = 15;
            this.nomColocataire = nomColocataire;
            btnValider.Click += btnValider_Click;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.login = tbIdentifiant.Text;
            this.password = tbMdp.Text;

            bool resultat = CaracteresDangereux(login, password);

            if (resultat == true)
            {
                string loginChiffrer = Chiffrement.ChiffrerBase64(this.login);
                string passwordChiffrer =Chiffrement.ChiffrerBase64(this.password);

                new DaoCompte().CreationCompte(loginChiffrer, passwordChiffrer, nomColocataire, State.compteCreation);

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
