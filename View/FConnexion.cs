﻿using System;
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
    public partial class FConnexion : Form
    {
        StateConnection stateConnection;
        string identifiant;
        string password;

        public FConnexion()
        {
            InitializeComponent();
            this.Text = "Connexion";
            this.stateConnection = StateConnection.disconnected;
            btnValider.Click += btnValider_Click;
        }

        public StateConnection StateConnection { 
            get { return this.stateConnection; }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.identifiant = tbIdentifiant.Text;
            this.password = tbMdp.Text;
            bool admin = false;

            bool caracteresDangereux = CaracteresDangereux(this.identifiant, this.password);

            if (caracteresDangereux == true)
            {
                MessageBox.Show("Les caractères spéciales sont interdites!","ATTENTION");
            }

            if (this.identifiant == "siojjr" && this.password == "siojjr" && caracteresDangereux == false)
            {
                stateConnection = StateConnection.connectedAdmin;
                admin = true;
                this.Close();
            } 

            if (admin == false && caracteresDangereux == false)
            {
                bool result = this.load(new DaoCompte().GetAll());

                if (result == true)
                {
                    stateConnection = StateConnection.connectedUser;
                    this.Close();
                }
                else
                {
                    stateConnection = StateConnection.error;
                    this.Close();
                }
            }
        }

        private bool CaracteresDangereux(string loginVerify, string passwordVerify)
        {
            bool loginCheck = loginVerify.Any(ch => !Char.IsLetterOrDigit(ch));
            bool passwordCheck = passwordVerify.Any(ch => !Char.IsLetterOrDigit(ch));

            if (loginCheck == true || passwordCheck == true)
            {
                return true;
            }

            return false;
        }

        private bool load(Comptes lesComptes)
        {
            for (int i = 0; i < lesComptes.Count(); i++)
            {
                string login = lesComptes[i].Login;
                string password = lesComptes[i].Password;

                if (this.identifiant == lesComptes[i].Login && this.password == lesComptes[i].Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}