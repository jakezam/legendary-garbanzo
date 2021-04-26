using System;
using System.Collections.Generic;
using legendary_garbanzo.Models;

/* These functions are used to mock data return without the need for a database */
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

        public IEnumerable<ProviderTypes> GetProviderTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetReviews(Guid userId, string receivedReviews)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewById(Guid reviewId)
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

        public IEnumerable<Job> GetJobs(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Job GetJobById(Guid jobId)
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