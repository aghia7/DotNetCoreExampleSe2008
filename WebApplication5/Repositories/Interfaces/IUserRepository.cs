using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void AddUser(User user);
        IEnumerable<User> GetUsers();
    }
}
