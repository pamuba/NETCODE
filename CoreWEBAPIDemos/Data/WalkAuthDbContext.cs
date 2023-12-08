using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreWEBAPIDemos.Data
{
    public class WalkAuthDbContext : IdentityDbContext
    {
        public WalkAuthDbContext(DbContextOptions<WalkAuthDbContext> options) : base(options) 
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerId = "EB0A293C-3456-4C68-BE1B-B0221AEC3823";
            var writerId = "2D393E1A-8F20-4C3C-8524-3A0D677B81E6";

            var roles = new List<IdentityRole>
            {
                new IdentityRole{
                    Id = readerId,
                    ConcurrencyStamp = readerId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },

                new IdentityRole{
                    Id = writerId,
                    ConcurrencyStamp = writerId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
