using ElectronicsStore.Domain.Entities;
using System.Data.Entity;

namespace ElectronicsStore.Domain.Concrete {

    public class EFDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
    }
}