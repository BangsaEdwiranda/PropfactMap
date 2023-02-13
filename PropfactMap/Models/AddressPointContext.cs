using Microsoft.EntityFrameworkCore;

namespace PropfactMap.Models
{
    public class AddressPointContext : DbContext
    {
        public AddressPointContext(DbContextOptions<AddressPointContext> options)
            : base(options)
        {
        }

        public DbSet<AddressPoint> AddressPoints { get; set; } = null!;
    }
}
