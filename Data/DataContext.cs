using legendary_garbanzo.Models;
using Microsoft.EntityFrameworkCore;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

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

        public DbSet<User> Users { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<PrivateMessage> PrivateMessages { get; set; }
    }
}