using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
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
