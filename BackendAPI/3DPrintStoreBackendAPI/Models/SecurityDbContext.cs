using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _3DPrintStoreBackendAPI.Models
{
    public class SecurityDbContext : IdentityDbContext<User>
    {
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("identity");
        }
    }
}
