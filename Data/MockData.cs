﻿using System;
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
                UserId = 00001,
                FirstName = "test",
                LastName = "test",
                DateOfBirth = new DateTime(),
                Gender = "test",
                State = "test",
                CreatedDate = new DateTime()
            };
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetSubCategoriesById(int providerId)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Provider> GetAllProviders(string category)
        {
            throw new NotImplementedException();
        }

        public Provider GetProviderById(int providerId)
        {
            throw new NotImplementedException();
        }

        public void CreateProvider(Provider provider)
        {
            throw new NotImplementedException();
        }

        public void UpdateProvider(Provider provider)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetReviews(string userId, string receivedReviews)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewById(int reviewId)
        {
            throw new NotImplementedException();
        }
        public void CreateReview(Review review)
        {
            throw new NotImplementedException();
        }
        public void UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetJobs(string userId)
        {
            throw new NotImplementedException();
        }
        public Job GetJobById(int jobId)
        {
            throw new NotImplementedException();
        }
        public void CreateJob(Job job)
        {
            throw new NotImplementedException();
        }
        public void UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}