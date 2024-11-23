using EDMIL.Communication.Domain.Entity.Product;
using EDMIL.Communication.Infra.Configs.Models;
using Microsoft.EntityFrameworkCore;

namespace EDMIL.Communication.Infra.Repositories
{
    public class CommunicationDBContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public CommunicationDBContext(
            DbContextOptions<CommunicationDBContext> options
        ) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfig());
        }

    }
}

