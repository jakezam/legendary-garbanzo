using System;
using System.Collections.Generic;
using System.Linq;
using legendary_garbanzo.Models;
using Microsoft.EntityFrameworkCore;

#pragma warning disable 1591 /*XML Doc String Warning*/

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

        #region Users
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(Guid userId)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public void CreateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Add(user);
        }


        public void SendMessage(PrivateMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            var from = _context.Users.Find(message.From);
            var to = _context.Users.Find(message.To);
            if (to == null || from == null)
                throw new ArgumentNullException(nameof(message));
            _context.PrivateMessages.Add(message);
            from.Sent.Add(message);
            to.Inbox.Add(message);
        }

        public void DeletePrivateMessage(PrivateMessage message)
        {
            _context.PrivateMessages.Remove(message);
        }
        public PrivateMessage GetPrivateMessage(Guid messageId)
        {
            return _context.PrivateMessages.Find(messageId);
        }
        public ICollection<PrivateMessage> GetUserInbox(Guid userId)
        {
            return _context.Users.Include(User => User.Inbox).FirstOrDefault(user => user.UserId == userId).Inbox;
        }

        public ICollection<PrivateMessage> GetUserSent(Guid userId)
        {
            return _context.Users.Include(User => User.Inbox).FirstOrDefault(user => user.UserId == userId).Sent;
        }

        public void UpdateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Update(user);
            
        }
        #endregion

        #region Categories
        public List<Category> GetCategoriesById(Guid providerId)
        {
            return _context.Categories.Where(sc => sc.ProviderId == providerId).ToList();
        }
        
        public void CreateCategory(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            _context.Categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            _context.Categories.Update(category);
            
        }
        #endregion

        #region Providers
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

        public Provider GetProviderById(Guid providerId)
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
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));
            
            _context.Providers.Update(provider);
        }
        #endregion


        public IEnumerable<ProviderTypes> GetProviderTypes()
        {
            return _context.ProviderTypes.ToList();
        } 

        // TODO: Update and test Reviews and Jobs API
        #region Reviews
        public IEnumerable<Review> GetReviews(Guid userId, string receivedReviews)
        {
            if (userId == null)
            {
                return _context.Reviews.ToList();
            }
            else
            {
                var id = userId;
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
        public Review GetReviewById(Guid reviewId)
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
        #endregion

        #region Jobs
        public IEnumerable<Job> GetJobs(Guid userId)
        {
            if (userId == null)
            {
                return _context.Jobs.ToList();
            }
            else
            {
                var id = userId;
                var jobs = _context.Jobs.ToList();
                var specific = from job in jobs
                               where job.UserId == id
                               select job;
                return specific;
            }
        }
        public Job GetJobById(Guid jobId)
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
        #endregion
    }
}