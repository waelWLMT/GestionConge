using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IUserRepository
    {
        User GetUserByLoginAndPassword(string login, string password);
    }
}
