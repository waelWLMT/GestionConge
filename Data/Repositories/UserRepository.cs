using Data.IRepositories;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByLoginAndPassword(string login, string password)
        {

            var users = new List<User>();

            // chercher la chaine de connection
            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";
            // creer la requete
            string query = "Select * from Users where login like '" + login + "' and password like '" + password+ "'";


            // creation d'une connection Sql
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // creation d'un commande à partir de la requete
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open(); // ouverture de la connection à la base de données

                    // execution de la requete
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read() && !users.Any())
                        {
                            var user = new User();

                            user.UserId = Convert.ToInt32(sdr["id_user"]);
                            user.Login = sdr["login"].ToString();
                            user.Password = sdr["password"].ToString();
                            user.Activated = Convert.ToBoolean(sdr["activated"]);

                            users.Add(user);

                        }
                    }

                    con.Close(); // fermuture de la connection à la base de données
                }
            }

            return users.FirstOrDefault();
        }

    }
}
