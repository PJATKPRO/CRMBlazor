using CRMBlazor.Data.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Data.CRMBlazorDb.Config
{
    internal sealed class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure
            (EntityTypeBuilder<Warehouse> entity)
        {
            entity.HasKey(e => e.Id);

            entity.OwnsOne(p => p.Address, od =>
            {
                od.Property(e => e.PostCode).HasMaxLength(6);
            });

            entity.HasOne(d => d.Company)
                .WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.CompanyId);


        }
    }
}
