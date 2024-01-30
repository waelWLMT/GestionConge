using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Users
    {
        public int IdUser { get; set; }
        public String Login { get; set; }

        public String Password { get; set; }



        public Users()
        {

        }

        public Users (int idUser, string login, string password)
        {
            IdUser = idUser;
            Login = login;
            Password = password;
        }


        public override string ToString()
        {
            return "Id User : " +IdUser+
                    "Login : " +Login+
                    "Password : " +Password;
        }
    }



}
