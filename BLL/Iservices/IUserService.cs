using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Iservices
{
   public interface IUserService
    {
        User Authenticate(string login, string password);

        void CreationUser(User user);

        void ModificationUser(User user);

        User AfficherUserById(int userId);

        void SuppressionUser(int userId);

        List<User> GetListUsers();



    }
}
