using BLL.Iservices;
using Data.Irepositories;
using Data.Repositories;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {

        private IUserRepository _userRepository;

        public UserService()
        {
            this._userRepository = new UserRepository();
        }

        public User AfficherUserById(int userId)
        {
            var user = this._userRepository.GetUserById(userId);
            return user;
        }

        public User Authenticate(string login, string password)
        {
            var user = this._userRepository.GetUserByLoginAndPassword(login, password);
            return user;
        }

        public void CreationUser(User user)
        {
             this._userRepository.AddUser(user);

        }

        public List<User> GetListUsers()
        {
            List<User> users = new List<User>();
            users = _userRepository.GetUsers();
            return users;
        }

        public void ModificationUser(User user)
        {
            this._userRepository.UpdateUser(user);
        }

        public void SuppressionUser(int userId)
        {
            this._userRepository.DeleteUser(userId);
        }
    }
}
