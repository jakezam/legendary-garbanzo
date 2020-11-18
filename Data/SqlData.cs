﻿using System;
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

        public IEnumerable<Review> GetReviews(string userId, string receivedReviews)
        {
            if (userId == null)
            {
                return _context.Reviews.ToList();
            }
            else
            {
                var id = Int16.Parse(userId);
                var reviews = _context.Reviews.ToList();
                var specific = from review in reviews
                               where review.UserId == id
                               select review;

                if (receivedReviews == "true")
                {
                    specific = from review in reviews
                               where review.ReceivingUserId == id
                               select review;
                }
                return specific;
            }
        }
        public Review GetReviewById(int reviewId)
        {
            return _context.Reviews.FirstOrDefault(u => u.ReviewId == reviewId);
        }
        public void CreateReview(Review review)
        {
            if (review == null)
                throw new ArgumentNullException(nameof(review));

            _context.Reviews.Add(review);
        }
        public void UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetJobs(string userId)
        {
            if (userId == null)
            {
                return _context.Jobs.ToList();
            }
            else
            {
                int id = Int16.Parse(userId);
                var jobs = _context.Jobs.ToList();
                var specific = from job in jobs
                               where job.UserId == id
                               select job;
                return specific;
            }
        }
        public Job GetJobById(int jobId)
        {
            return _context.Jobs.FirstOrDefault(u => u.Id == jobId);
        }
        public void CreateJob(Job job)
        {
            if (job == null)
                throw new ArgumentNullException(nameof(job));

            _context.Jobs.Add(job);
        }
        public void UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}