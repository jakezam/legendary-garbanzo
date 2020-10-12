using System;
using System.Collections.Generic;
using System.Linq;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Data
{
    public class SqlData : IData
    {
        private readonly DataContext _context;
        public SqlData(DataContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public void CreateUser(User user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Add(user);
        }
    }
}