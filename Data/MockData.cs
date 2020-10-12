using System;
using System.Collections.Generic;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Data
{
    public class MockData : IData
    {
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    UserId = 00001, FirstName = "Bill", LastName = "test", DateOfBirth = new DateTime(), Gender = "test",
                    State = "test", CreatedDate = new DateTime()
                },
                new User
                {
                    UserId = 00002, FirstName = "Sam", LastName = "test", DateOfBirth = new DateTime(), Gender = "test",
                    State = "test", CreatedDate = new DateTime()
                },
                new User
                {
                    UserId = 00003, FirstName = "Tom", LastName = "test", DateOfBirth = new DateTime(), Gender = "test",
                    State = "test", CreatedDate = new DateTime()
                },
            };

            return users;
        }

        public User GetUserById(int userId)
        {
            return new User
            {
                UserId = 00001, FirstName = "test", LastName = "test", DateOfBirth = new DateTime(), Gender = "test",
                State = "test", CreatedDate = new DateTime()
            };
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}