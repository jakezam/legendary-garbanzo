using legendary_garbanzo.Models;
using Microsoft.EntityFrameworkCore;

namespace legendary_garbanzo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {
        }

        // Create tables for the database
        public DbSet<User> Users { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ProviderTypes> ProviderTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PrivateMessage> PrivateMessages { get; set; }

        // Special settings, our category will have a custom key set and on add CategoryNumber will be auto generated
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Configure category multi-key requirement as Composite primary
             keys can only be set using 'HasKey' in 'OnModelCreating' */
            modelBuilder.Entity<Category>()
                .HasKey(c => new {c.ProviderId, c.CategoryNumber});
            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryNumber)
                .ValueGeneratedOnAdd();
        }
    }
}