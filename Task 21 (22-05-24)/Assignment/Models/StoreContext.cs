using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {
            
        }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
