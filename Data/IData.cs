using System.Collections;
using System.Collections.Generic;
using legendary_garbanzo.Models;

namespace legendary_garbanzo.Data
{
    public interface IData
    {
        bool SaveChanges();
        
        // Users //
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        void CreateUser(User user);
        void UpdateUser(User user);
        
        // SubCategories //
        List<SubCategory> GetSubCategoriesById(int providerId);

        // Providers //
        IEnumerable<Provider> GetAllProviders(string category);
        Provider GetProviderById(int providerId);
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