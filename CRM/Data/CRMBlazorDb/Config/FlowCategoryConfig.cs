using CRMBlazor.Data.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Data.CRMBlazorDb.Config
{
    internal sealed class FlowCategoryConfig : IEntityTypeConfiguration<FlowCategory>
    {
        public void Configure
            (EntityTypeBuilder<FlowCategory> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Color).HasMaxLength(64);

        }
    }
}
