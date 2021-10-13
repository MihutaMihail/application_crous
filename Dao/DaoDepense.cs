using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Dao
{
    public class DaoDepense
    {
        public void SaveChanges(List<Depense> lesDepenses)
        {
            for (int i = 0; i < lesDepenses.Count; i++)
            {
                Depense depense = lesDepenses[i];
                switch (depense.State)
                {
                    case State.added:
                        this.insert(depense);
                        break;
                    case State.modified:
                        this.update(depense);
                        break;
                    case State.deleted:
                        this.delete(depense);
                        lesDepenses.Remove(depense);
                        break;
                }
            }
        }
        private void insert(Depense depense)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into Depenses(dateDepense,titre,justificatif,montant,reparti,idColocataire) " +
                    "values(@dateDepense,@titre,@justificatif,@montant,@reparti,@id)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@dateDepense", MySqlDbType.DateTime));
                    cmd.Parameters["@dateDepense"].Value = depense.Date;

                    cmd.Parameters.Add(new MySqlParameter("@titre", MySqlDbType.VarChar));
                    cmd.Parameters["@titre"].Value = depense.Titre;

                    cmd.Parameters.Add(new MySqlParameter("@justificatif", MySqlDbType.VarChar));
                    cmd.Parameters["@justificatif"].Value = depense.Justificatif;

                    cmd.Parameters.Add(new MySqlParameter("@montant", MySqlDbType.Int32));
                    cmd.Parameters["@montant"].Value = depense.Montant;

                    cmd.Parameters.Add(new MySqlParameter("@reparti", MySqlDbType.Bit));
                    cmd.Parameters["@reparti"].Value = depense.Reparti;

                    cmd.ExecuteNonQuery();
                }
            }
            depense.State = State.unChanged;
        }
        private void update(Depense depense)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update Depenses set dateDepense=@dateDepense,titre=@titre,justificatif=@justificatif," +
                    "montant=@montant,reparti=@reparti", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@dateDepense", MySqlDbType.DateTime));
                    cmd.Parameters["@dateDepense"].Value = depense.Date;

                    cmd.Parameters.Add(new MySqlParameter("@titre", MySqlDbType.VarChar));
                    cmd.Parameters["@titre"].Value = depense.Titre;

                    cmd.Parameters.Add(new MySqlParameter("@justificatif", MySqlDbType.VarChar));
                    cmd.Parameters["@justificatif"].Value = depense.Justificatif;

                    cmd.Parameters.Add(new MySqlParameter("@montant", MySqlDbType.Int32));
                    cmd.Parameters["@montant"].Value = depense.Montant;

                    cmd.Parameters.Add(new MySqlParameter("@reparti", MySqlDbType.Bit));
                    cmd.Parameters["@reparti"].Value = depense.Reparti;

                    cmd.ExecuteNonQuery();
                }
            }
            depense.State = State.unChanged;
        }
        private void delete(Depense depense)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from Depenses where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = depense.Id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Depense> GetAll(int idColocataire)
        {
            List<Depense> lesDepenses = new List<Depense>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,dateDepense,titre,justificatif,montant,reparti from depenses" +
                    "where idColocataire=@idColocataire", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lesDepenses.Add(new Depense(Convert.ToInt32(rdr["id"]), (DateTime)rdr["dateDepense"], (string)rdr["titre"], (string)rdr["justificatif"],
                                Convert.ToInt32(rdr["montant"]), (Boolean)rdr["reparti"], State.unChanged));
                        }
                    }
                }
            }
            return lesDepenses;
        }

    }
}
