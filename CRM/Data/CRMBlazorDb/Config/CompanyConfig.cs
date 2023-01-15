using CRMBlazor.Data.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Data.CRMBlazorDb.Config
{
    internal sealed class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure
            (EntityTypeBuilder<Company> entity)
        {
            entity.HasKey(e => e.Id);
            entity.OwnsOne(p => p.Address, od =>
            {
                od.Property(e => e.PostCode).HasMaxLength(6);
            });

            entity.Property(e => e.Phone).HasMaxLength(13);
            entity.Property(e => e.Nip).HasMaxLength(10);
            entity.Property(e => e.Krs).HasMaxLength(10);
            entity.Property(e => e.Regon).HasMaxLength(9);
            entity.Property(e => e.AdditionalInfo).HasMaxLength(500);
            entity.HasOne(d => d.CompanyType).WithMany(p => p.Companies).HasForeignKey(d => d.CompanyTypeId);


        }
    }
}
