using ElectroMarket.Domain.Entities;
using System.Data.Entity;

namespace ElectroMarket.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
