using CoreWEBAPIDemos.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoreWEBAPIDemos.Data
{
    public class WalkDbContext : DbContext
    {
        public WalkDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        {
                
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

    }
}
