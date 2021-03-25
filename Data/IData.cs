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
        void SendMessage(PrivateMessage message);
        
        // Categories //
        List<Category> GetCategoriesById(Guid providerId);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);

        // Providers //
        IEnumerable<Provider> GetAllProviders(string category);
        Provider GetProviderById(Guid providerId);
        void CreateProvider(Provider provider);
        void UpdateProvider(Provider provider);

        // Reviews //
        IEnumerable<Review> GetReviews(string userId, string receivedReviews);
        Review GetReviewById(int reviewId);
        void CreateReview(Review review);
        void UpdateReview(Review review);

        // Jobs //
        IEnumerable<Job> GetJobs(string userId);
        Job GetJobById(int jobId);
        void CreateJob(Job job);
        void UpdateJob(Job job);
    }
}