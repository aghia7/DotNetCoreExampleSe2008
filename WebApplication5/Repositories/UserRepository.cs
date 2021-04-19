using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Data;
using WebApplication5.Models;
using WebApplication5.Repositories.Interfaces;

namespace WebApplication5.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }
    }
}
