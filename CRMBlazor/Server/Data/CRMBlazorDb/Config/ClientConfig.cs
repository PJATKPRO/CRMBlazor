using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Server.Data.CRMBlazorDb.Config
{
    internal sealed class ClientConfig : IEntityTypeConfiguration<Shared.Data.CRMBlazorDb.Models.Client>
    {
        public void Configure
            (EntityTypeBuilder<Shared.Data.CRMBlazorDb.Models.Client> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PeselOrNip).HasMaxLength(50);
            entity.OwnsOne(p => p.Address, od =>
            {
                od.Property(e => e.PostCode).HasMaxLength(6);
            });

            entity.OwnsOne(x => x.InvestitionAddress, od =>
            {
                od.Property(e => e.PostCode).HasMaxLength(6);
            });

        }
    }
}
