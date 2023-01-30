using CRMBlazor.Data.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Data.CRMBlazorDb.Config
{
    internal sealed class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure
            (EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.ProductName).HasMaxLength(128);
            entity.Property(e => e.Company).HasMaxLength(128);
            entity.Property(e => e.PurchasePrice).HasPrecision(13, 2);
            entity.Property(e => e.SellingPrice).HasPrecision(13, 2);


            entity.HasOne(d => d.Warehouse)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.WarehouseId);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId);

        }
    }
}
