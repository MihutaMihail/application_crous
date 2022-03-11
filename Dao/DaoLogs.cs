using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Dao
{
    public class DaoLogs
    {
        public void CreationLog(string identifiant, string adresseIp, DateTime dateLog, string action, State state)
        {
            switch (state)
            {
                case State.logCreation:
                    this.logCreation(identifiant,adresseIp,dateLog,action);
                    break;
            }
        }

        private void logCreation(string identifiant, string adresseIp, DateTime dateLog, string action)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into logs(identifiant, adresseIp, dateLog, action) values(@identifiant, @adresseIp, @dateLog, @action)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@identifiant", MySqlDbType.VarChar));
                    cmd.Parameters["@identifiant"].Value = identifiant;

                    cmd.Parameters.Add(new MySqlParameter("@adresseIp", MySqlDbType.VarChar));
                    cmd.Parameters["@adresseIp"].Value = adresseIp;

                    cmd.Parameters.Add(new MySqlParameter("@dateLog", MySqlDbType.DateTime));
                    cmd.Parameters["@dateLog"].Value = dateLog;

                    cmd.Parameters.Add(new MySqlParameter("@action", MySqlDbType.VarChar));
                    cmd.Parameters["@action"].Value = action;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public CollectionLogs GetAll()
        {
            CollectionLogs lesLogs = new CollectionLogs();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select identifiant,dateLog,action from logs", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lesLogs.AjouterLog(new Logs(Convert.ToInt32(rdr["id"]), (string)rdr["identifiant"],(string)rdr["adresseIp"],(DateTime)rdr["dateLog"], (string)rdr["action"]));
                        }
                    }
                }
            }
            return lesLogs;
        }
    }
}
