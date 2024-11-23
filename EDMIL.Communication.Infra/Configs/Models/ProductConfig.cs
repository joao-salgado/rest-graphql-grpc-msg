using EDMIL.Communication.Domain.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDMIL.Communication.Infra.Configs.Models
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(category => category.Id);
            builder.Property(category => category.Name)
                .HasMaxLength(255);
        }
    }
}
