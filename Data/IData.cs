using System.Collections;
using System.Collections.Generic;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Data
{
    public interface IData
    {
        bool SaveChanges();
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        void CreateUser(User user);
        void UpdateUser(User user);
    }
}