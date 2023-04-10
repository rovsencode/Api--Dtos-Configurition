using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P326FirstWebAPI.Models;

namespace P326FirstWebAPI.Data.Configuritions
{
    public class ProductConfigurition : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p=>p.Name).HasMaxLength(50);
            builder.Property(p => p.SalePrice).IsRequired(true);
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("GetUtcDate()");
            builder.Property(p => p.Name).HasDefaultValue(DateTime.UtcNow);

        }
    }
}
