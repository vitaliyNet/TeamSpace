using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TeamSpace.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Work> Works { get; set; }
        public DbSet<TaskName> TaskNames { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}