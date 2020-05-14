using System;
using ActivityService.Domain;
using Microsoft.EntityFrameworkCore;

namespace ActivityService.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }


        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}