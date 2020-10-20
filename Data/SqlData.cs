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
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            // Do Nothing
        }

        public IEnumerable<Provider> GetAllProviders(string category)
        {
            if (category == null)
            {
                return _context.Providers.ToList();
            }
            else
            {
                var providers = _context.Providers.ToList();
                var specific = from provider in providers
                               where provider.Category == category
                               select provider;
                return specific;
            }
        }

        public Provider GetProviderById(int providerId)
        {
            return _context.Providers.FirstOrDefault(u => u.ProviderId == providerId);
        }

        public void CreateProvider(Provider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            _context.Providers.Add(provider);
        }

        public void UpdateProvider(Provider provider)
        {
            throw new NotImplementedException();
        }
    }
}