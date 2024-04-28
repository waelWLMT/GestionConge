
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
    public class UserRepository : IUserRepository
    {

        // creation d'un nouveau user
        public void AddUser(User user)
        {
           
            var con = MySingletonConn.getInstance().Connection;
            var query = "INSERT INTO Users (nom, prenom, login, password, activated) VALUES(@nom, @prenom, @login, @password, @activated)";

            try
            {
                var cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@nom", user.Nom);
                cmd.Parameters.AddWithValue("@prenom", user.Prenom);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@activated", user.Activated);
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

        public void DeleteUser(int userId)
        {
            var con = MySingletonConn.getInstance().Connection;
            var query = "DELETE FROM Users WHERE UserId=@idUser";
            var cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@idUser", userId);
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

        public User GetUserById(int userId)
        {
            var con = MySingletonConn.getInstance().Connection;
            var query = "SELECT * FROM Users WHERE UserId = " + userId;
            var cmd = new SqlCommand(query, con);
            var user = new User();

            try
            {
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        user.UserId = Convert.ToInt32(dr["UserId"]);
                        user.Nom = Convert.ToString(dr["Nom"]);
                        user.Prenom = Convert.ToString(dr["Prenom"]);
                        user.Login = Convert.ToString(dr["Login"]);
                        user.Password = Convert.ToString(dr["Password"]);
                        user.Activated = Convert.ToBoolean(dr["Activated"]);
                    }
                    return user;
                }

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

        public User GetUserByLoginAndPassword(string login, string password)
        {
            var users = new List<User>();
            var con = MySingletonConn.getInstance().Connection;
            var query = "SELECT * FROM Users WHERE Login like'" + login + "'and Password like '" + password + "'";
            var cmd = new SqlCommand(query, con);

            try
            {
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read() && !users.Any())
                    {
                        var user = new User();
                        user.UserId = Convert.ToInt32(dr["UserId"]);
                        user.Login = Convert.ToString(dr["Login"]);
                        user.Password = Convert.ToString(dr["Password"]);
                        user.Activated = Convert.ToBoolean(dr["Activated"]);
                        users.Add(user);
                    }
                }

                return users.FirstOrDefault();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public User GetUserByName(string name)
        {
            var con = MySingletonConn.getInstance().Connection;
            var query = "SELECT * FROM Users WHERE Nom like'" + name+"'";
            var cmd = new SqlCommand(query, con);
            var user = new User();

            try
            {
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        user.UserId = Convert.ToInt32(dr["UserId"]);
                        user.Nom = Convert.ToString(dr["Nom"]);
                        user.Prenom = Convert.ToString(dr["Prenom"]);
                        user.Login = Convert.ToString(dr["Login"]);
                        user.Password = Convert.ToString(dr["Password"]);
                        user.Activated = Convert.ToBoolean(dr["Activated"]);
                    }
                    return user;
                }

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

        public List<User> GetUsers()
        {
            var users = new List<User>();
            var con = MySingletonConn.getInstance().Connection;

            try
            {
                var query = "SELECT * FROM Users";
                con.Open();
                var cmd = new SqlCommand(query);

                cmd.Connection = con;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User user = new User();
                        user.UserId = Convert.ToInt32(dr["UserId"]);
                        user.Login = Convert.ToString(dr["Login"]);
                        user.Password = Convert.ToString(dr["Password"]);
                        user.Nom = Convert.ToString(dr["Nom"]);
                        user.Prenom = Convert.ToString(dr["Prenom"]);
                        user.Activated = Convert.ToBoolean(dr["Activated"]);
                        users.Add(user);
                    }
                }

                return users;

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

        public void UpdateUser(User user)
        {

            var con = MySingletonConn.getInstance().Connection;
            var query = "UPDATE Users SET  Nom =@nom, Prenom = @prenom, Login=@login,  Password=@password, Activated=@activated WHERE UserId=@id_user";
            var cmd = new SqlCommand (query, con);

            try
            {
                con.Open();

                cmd.Parameters.AddWithValue("@id_user", user.UserId);
                cmd.Parameters.AddWithValue("@nom", user.Nom);
                cmd.Parameters.AddWithValue("@prenom", user.Prenom);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@activated", user.Activated);
                
                cmd.ExecuteNonQuery();               

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close() ;
            }

        }
    }
}
