
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    { // base は DbContext 内の constractor 
        public DataContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<Activity> Activities { get; set; }
    }
}