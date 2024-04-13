using Data.IRepositories;
using Data.Repositories;
using Models.Entities;
using Services.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : IUserService
    {

        private IUserRepository _userRepository;

        public UserService()
        {
            this._userRepository = new UserRepository();
        }

        public User Authenticate(string login, string password)
        {            
            var user = this._userRepository.GetUserByLoginAndPassword(login, password);
            return user;
           
        }
    
    
    }
}
