using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Dao
{
    public class DaoCompte
    {
        public void CreationCompte(string login, string password, string nomColocataire, State state)
        {
            switch (state)
            {
                case State.compteCreation:
                    this.compteCreation(login, password, nomColocataire);
                    break;
            }
        }

        private void compteCreation(string login, string password, string nomColocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into compte(login,password,nomColocataire) values(@login,@password,@nomColocataire)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@login", MySqlDbType.VarChar));
                    cmd.Parameters["@login"].Value = login;

                    cmd.Parameters.Add(new MySqlParameter("@password", MySqlDbType.VarChar));
                    cmd.Parameters["@password"].Value = password;

                    cmd.Parameters.Add(new MySqlParameter("@nomColocataire", MySqlDbType.VarChar));
                    cmd.Parameters["@nomColocataire"].Value = nomColocataire;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Comptes GetAll()
        {
            Comptes lesComptes = new Comptes();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select login,nomColocataire from compte", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lesComptes.AjouterCompte(new Compte((string)rdr["login"], (string)rdr["password"], (string)rdr["nomColocataire"]));
                        }
                    }
                }
            }
            return lesComptes;
        }
    }
}
