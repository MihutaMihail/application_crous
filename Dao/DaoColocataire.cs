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
        public void SaveChanges(Colocataires lesColocataires)
        {
            for (int i = 0; i < lesColocataires.Count(); i++)
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
                        lesColocataires.SupprimerColocataire(colocataire);
                        break;
                }
            }
        }

        private void insert(Colocataire colocataire)
        {
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into Colocataire(nom,prenom,age,numTel,adresseMail,appartement) values(@nom,@prenom,@age,@numTel,@adresseMail,@appartement)", cnx))
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

                    cmd.Parameters.Add(new MySqlParameter("@appartement", MySqlDbType.Int32));
                    cmd.Parameters["@appartement"].Value = colocataire.Appartement;

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
                using (MySqlCommand cmd = new MySqlCommand("update Colocataire set nom=@nom,prenom=@prenom,age=@age,numTel=@numTel,adresseMail=@adresseMail,appartement=@appartement" +
                    " where id=@id", cnx))
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

                    cmd.Parameters.Add(new MySqlParameter("@appartement", MySqlDbType.Int32));
                    cmd.Parameters["@appartement"].Value = colocataire.Appartement;

                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = colocataire.Id;

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
                    try
                    {
                        cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
                        cmd.Parameters["@id"].Value = colocataire.Id;
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException e)
                    {
                        
                    }
                }
            }
        }
        public Colocataires GetAll()
        {
            Colocataires lesColocataires = new Colocataires();
            using (MySqlConnection cnx = DaoConnectionSingleton.GetMySqlConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,age,numTel,adresseMail,appartement from colocataire", cnx))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lesColocataires.AjouterColocataire(new Colocataire(Convert.ToInt32(rdr["id"]), (string)rdr["nom"], (string)rdr["prenom"], Convert.ToInt32(rdr["age"]),
                                Convert.ToInt32(rdr["numTel"]), (string)rdr["adresseMail"], Convert.ToInt32(rdr["appartement"]), State.unChanged));
                        }
                    }
                }
            }
            return lesColocataires;
        }
    }
}