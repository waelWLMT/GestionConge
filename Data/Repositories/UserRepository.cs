
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
            var query = "INSERT INTO Users (login, password, activated) VALUES(@login, @password, @activated)";

            try
            {
                var cmd = new SqlCommand(query, con);
                con.Open();
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
            var query = "DELETE FROM Users WHERE id_user=@idUser";
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
            var query = "SELECT * FROM Users WHERE id_user = " + userId;
            var cmd = new SqlCommand(query, con);
            var user = new User();

            try
            {
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
            var query = "SELECT * FROM Users WHERE login like'" + login + "'and password like '" + password + "'";
            var cmd = new SqlCommand(query, con);

            try
            {
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

        public List<User> GetUsers()
        {
            var users = new List<User>();
            var con = MySingletonConn.getInstance().Connection;

            try
            {
                var query = "SELECT id_user, login, password, activated FROM Users";
                var cmd = new SqlCommand(query);

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
            var query = "UPDATE Users SET login=@login, password=@password, activated=@activated WHERE id_user=@id_user";
            var cmd = new SqlCommand (query, con);

            try
            {
                con.Open();

                cmd.Parameters.AddWithValue("@id_user", user.UserId);
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
