using System;
using System.Collections;
using System.Collections.Generic;
using legendary_garbanzo.Models;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Data
{
    public interface IData
    {
        bool SaveChanges();
        
        // Users //
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid userId);
        void CreateUser(User user);
        void UpdateUser(User user);
        
        
        // Categories //
        List<Category> GetCategoriesById(Guid providerId);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);

        // Providers //
        IEnumerable<Provider> GetAllProviders(string category);
        Provider GetProviderById(Guid providerId);
        void CreateProvider(Provider provider);
        void UpdateProvider(Provider provider);

        // ProvidersTypes //
        IEnumerable<ProviderTypes> GetProviderTypes();

        // Reviews //
        IEnumerable<Review> GetReviews(Guid userId, string receivedReviews);
        Review GetReviewById(Guid reviewId);
        void CreateReview(Review review);
        void UpdateReview(Review review);

        // Jobs //
        IEnumerable<Job> GetJobs(Guid userId);
        Job GetJobById(Guid jobId);
        void CreateJob(Job job);
        void UpdateJob(Job job);

        // Messages //
        ICollection<PrivateMessage> GetUserInbox(Guid userId);
        ICollection<PrivateMessage> GetUserSent(Guid userId);
        void SendMessage(PrivateMessage message);
        PrivateMessage GetPrivateMessage(Guid messageId);
        void DeletePrivateMessage(PrivateMessage message);
    }
}