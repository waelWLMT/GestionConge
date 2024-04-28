
using Core.Models;
using System.Collections.Generic;

namespace Data.IRepositories
{
    public interface IUserRepository
    {
        User GetUserByLoginAndPassword(string login, string password);

        void AddUser(User user);

        void UpdateUser(User user);

        User GetUserById(int userId);

        void DeleteUser(int userId);

        List<User> GetUsers();

    }
}
