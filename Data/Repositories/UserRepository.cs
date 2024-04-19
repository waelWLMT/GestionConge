using Data.Irepositories;
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

        // creation d'un nouveau user
        public void AddUser(User user)
        {
            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";
            string query = "INSERT INTO Users (login, password, activated) VALUES(@login, @password, @activated)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))

                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@login", user.Login);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@activated", user.Activated);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }

        public void DeleteUser(int userId)
        {
            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";

            string query = "DELETE FROM Users WHERE id_user=@idUser";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@idUser", userId);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public User GetUserById(int userId)
        {
            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";

            string query = "SELECT * FROM Users WHERE id_user = " + userId;
            var user = new User();

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            user.UserId = Convert.ToInt32(dr["id_user"]);
                            user.Login = Convert.ToString(dr["login"]);
                            user.Password = Convert.ToString(dr["password"]);
                            user.Activated = Convert.ToBoolean(dr["activated"]);

                        }
                    }
                    con.Close();
                }
            }


            return user;
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            var users = new List<User>();

            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";


            string query = "SELECT * FROM Users WHERE login like'" +login+ "'and password like '"+password+"'";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                            using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read() && !users.Any())
                            {
                            var user = new User();
                            user.UserId = Convert.ToInt32(dr["id_user"]);
                            user.Login = Convert.ToString(dr["login"]);
                            user.Password = Convert.ToString(dr["password"]);
                            user.Activated = Convert.ToBoolean(dr["activated"]);
                            users.Add(user);
                            }
                        }
                        con.Close();
                    }
                }

                
                return users.FirstOrDefault();


            }

        public List<User> GetUsers()
        {
            List <User> users = new List<User>();

            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";


            string query = "SELECT id_user, login, password, activated FROM Users";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            User user = new User();
                            user.UserId = Convert.ToInt32(dr["id_user"]);
                            user.Login = Convert.ToString(dr["login"]);
                            user.Password = Convert.ToString(dr["password"]);
                            user.Activated = Convert.ToBoolean(dr["activated"]);
                            users.Add(user);
                        }
                    }
                    con.Close();
                }
            }


            return users;
        }

        public void UpdateUser(User user)
        {
            var connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";
            string query = "UPDATE Users SET login=@login, password=@password, activated=@activated WHERE id_user=@id_user";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@id_user", user.UserId);
                        cmd.Parameters.AddWithValue("@login", user.Login);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@activated", user.Activated);

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
    }
}
