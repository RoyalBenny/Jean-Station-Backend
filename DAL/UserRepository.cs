using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly JeanStationDbContext _context;
        public UserRepository(JeanStationDbContext con)
        {
            _context = con;
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetUser(string id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
