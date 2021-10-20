using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Dao
{
    public class DaoColocataire
    {
        public void SaveChanges(List<Colocataire> lesColocataires)
        {
            for (int i = 0; i < lesColocataires.Count; i++)
            {
                Colocataire colocataire = lesColocataires[i];
                switch (colocataire.State)
                {
                    case State.added:
                        this.insert(colocataire);
                        break;
                    case State.modified:
                        this.update(colocataire);
                        break;
                    case State.deleted:
                        this.delete(colocataire);
                        lesColocataires.Remove(colocataire);
                        break;
                }
            }
        }
        private void insert(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into Colocataire(nom,prenom,age,numTel,adresseMail) values(@nom,@prenom,@age,@numTel,@adresseMail)", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters["@nom"].Value = colocataire.Nom;

                    cmd.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                    cmd.Parameters["@prenom"].Value = colocataire.Prenom;

                    cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                    cmd.Parameters["@age"].Value = colocataire.Age;

                    cmd.Parameters.Add(new MySqlParameter("@numTel", MySqlDbType.Int32));
                    cmd.Parameters["@numTel"].Value = colocataire.NumTel;

                    cmd.Parameters.Add(new MySqlParameter("@adresseMail", MySqlDbType.VarChar));
                    cmd.Parameters["@adresseMail"].Value = colocataire.AdresseMail;

                    cmd.ExecuteNonQuery();
                }
            }
            colocataire.State = State.unChanged;
        }
        private void update(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update Colocataire set nom=@nom,prenom=@prenom,age=@age,numTel=@numTel,adresseMail=@adresseMail" +
                    " where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = colocataire.Id;

                    cmd.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                    cmd.Parameters["@nom"].Value = colocataire.Nom;

                    cmd.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                    cmd.Parameters["@prenom"].Value = colocataire.Prenom;

                    cmd.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
                    cmd.Parameters["@age"].Value = colocataire.Age;

                    cmd.Parameters.Add(new MySqlParameter("@numTel", MySqlDbType.Int32));
                    cmd.Parameters["@numTel"].Value = colocataire.NumTel;

                    cmd.Parameters.Add(new MySqlParameter("@adresseMail", MySqlDbType.VarChar));
                    cmd.Parameters["@adresseMail"].Value = colocataire.AdresseMail;

                    cmd.ExecuteNonQuery();
                }
            }
            colocataire.State = State.unChanged;
        }
        private void delete(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from Colocataire where id=@id", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = colocataire.Id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Colocataire> GetAll()
        {
            List<Colocataire> lesColocataires = new List<Colocataire>();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,age,numTel,adresseMail from colocataire", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lesColocataires.Add(new Colocataire(Convert.ToInt32(rdr["id"]), (string)rdr["nom"], (string)rdr["prenom"], Convert.ToInt32(rdr["age"]),
                                Convert.ToInt32(rdr["numTel"]), (string)rdr["adresseMail"], State.unChanged));
                        }
                    }
                }
            }
            return lesColocataires;
        }
    }
}