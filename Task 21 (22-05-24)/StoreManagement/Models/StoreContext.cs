using Microsoft.EntityFrameworkCore;

namespace StoreManagement.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }


    }
}
