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
        public void CreationCompte(string login, string password, State state)
        {
            switch (state)
            {
                case State.compteCreation:
                    this.compteCreation(login, password);
                    break;
            }
        }

        private void compteCreation(string login, string password)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into compte(login,password) values(@login,@password)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@login", MySqlDbType.VarChar));
                    cmd.Parameters["@login"].Value = login;

                    cmd.Parameters.Add(new MySqlParameter("@password", MySqlDbType.VarChar));
                    cmd.Parameters["@password"].Value = password;

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
                using (MySqlCommand cmd = new MySqlCommand("select login,password from compte", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lesComptes.AjouterCompte(new Compte((string)rdr["login"], (string)rdr["password"]));
                        }
                    }
                }
            }
            return lesComptes;
        }
    }
}
