using System;
using System.Collections.Generic;
using legendary_garbanzo.Models;
#pragma warning disable 1591 /*XML Doc String Warning*/
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
            throw new NotImplementedException();
        }

        public User GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(PrivateMessage message)
        {
            throw new NotImplementedException();
        }
        public void DeletePrivateMessage(PrivateMessage message)
        {
            throw new NotImplementedException();
        }
        public PrivateMessage GetPrivateMessage(Guid messageId)
        {
            throw new NotImplementedException();
        }
        public ICollection<PrivateMessage> GetUserInbox(Guid userId)
        {
            throw new NotImplementedException();
        }
        public ICollection<PrivateMessage> GetUserSent(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoriesById(Guid providerId)
        {
            throw new NotImplementedException();
        }

        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoriesById(int providerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Provider> GetAllProviders(string category)
        {
            throw new NotImplementedException();
        }

        public Provider GetProviderById(Guid providerId)
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