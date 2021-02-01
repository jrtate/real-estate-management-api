using Microsoft.EntityFrameworkCore;

namespace RealEstateManagementAPI.Models
{
    public class RealEstateManagementContext : DbContext
    {
        public RealEstateManagementContext(DbContextOptions<RealEstateManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Deposits> Deposits { get; set; }
    }
}
