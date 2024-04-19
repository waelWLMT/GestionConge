using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Boolean Activated { get; set; }

        public User()
        {

        }

        public User( string login, string password)
        {
            Login = login;
            Password = password;
        }
    }


    

}
