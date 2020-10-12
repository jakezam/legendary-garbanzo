﻿using legendary_garbanzo.Models;
using Microsoft.EntityFrameworkCore;

namespace legendary_garbanzo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
    }
}