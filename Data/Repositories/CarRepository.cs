using Core.Models;
using Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{

    public class CarRepository : ICarRepository

    {
        public void AddCar(Voiture car)
        {
            var con = MySingletonConn.getInstance().Connection;
            var query = "INSERT INTO Voitures (Immatriculation, MarqueId, ModelId, ProprietaireId) VALUES(@immatriculation, @marque, @model, @proprietaireId)";

            try
            {
                var cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@immatriculation", car.Immatriculation);
                cmd.Parameters.AddWithValue("@marque", car.MarqueId);
                cmd.Parameters.AddWithValue("@model", car.ModeleId);
                cmd.Parameters.AddWithValue("@proprietaireId", car.ProprietaireId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        public List<Voiture> GetListCars()
        {
            List<Voiture> voitures = new List<Voiture>();
            var con = MySingletonConn.getInstance().Connection;

            try
            {
                var query = "SELECT * FROM Voitures";
                con.Open();
                var cmd = new SqlCommand(query);

                cmd.Connection = con;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Voiture voiture = new Voiture();
                        voiture.VoitureId = Convert.ToInt32(dr["VoitureId"]);
                        voiture.Immatriculation = Convert.ToString(dr["Immatriculation"]);
                        voiture.ModeleId= Convert.ToInt32(dr["ModelId"]);
                        voiture.MarqueId= Convert.ToInt32(dr["MarqueId"]);
                        voiture.Annee = Convert.ToString(dr["Annee"]);
                        voiture.ProprietaireId = Convert.ToInt32(dr["ProprietaireId"]);
                        voitures.Add(voiture);
                    }
                }

                return voitures;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Marque> GetMarque()
        {
            List<Marque> marques = new List<Marque>();
            var con = MySingletonConn.getInstance().Connection;

            try
            {
                var query = "SELECT LibelleMarque FROM Marques";
                con.Open();
                var cmd = new SqlCommand(query);

                cmd.Connection = con;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Marque marque = new Marque();
                        marque.LibelleMarque = Convert.ToString(dr["LibelleMarque"]);
                        marques.Add(marque);
                    }
                }

                return marques;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Model> GetModel(string NameMarque)
        {
            List<Model> models = new List<Model>();
            var con = MySingletonConn.getInstance().Connection;

            try
            {
                var query = "SELECT LibelleModel FROM Models INNER JOIN Marques ON Models.MarqueId=Marques.MarqueId " +
                    "Where LibelleMarque = '"+NameMarque+"'";
                con.Open();
                var cmd = new SqlCommand(query);

                cmd.Connection = con;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Model model = new Model();
                        model.LibelleModel = Convert.ToString(dr["LibelleModel"]);
                        models.Add(model);
                    }
                }

                return models;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<User> GetProprietaire()
        {
            List<User> proprietaires = new List<User>();
            var con = MySingletonConn.getInstance().Connection;

            try
            {
                var query = "SELECT UserId, Nom, Prenom FROM Users";
                con.Open();
                var cmd = new SqlCommand(query);

                cmd.Connection = con;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User user = new User();
                        user.UserId = Convert.ToInt32(dr["UserId"]);
                        user.Nom = Convert.ToString(dr["Nom"]);
                        user.Prenom = Convert.ToString(dr["Prenom"]);
                        proprietaires.Add(user);
                    }
                }

                return proprietaires;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
