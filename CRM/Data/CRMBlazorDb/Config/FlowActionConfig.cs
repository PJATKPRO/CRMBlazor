using CRMBlazor.Data.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Data.CRMBlazorDb.Config
{
    internal sealed class FlowActionConfig : IEntityTypeConfiguration<FlowAction>
    {
        public void Configure
            (EntityTypeBuilder<FlowAction> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Type).HasMaxLength(64).HasConversion(typeof(string));
            entity.HasOne(d => d.Category).WithMany(p => p.FlowAction).HasForeignKey(d => d.FlowCategoryId);

        }
    }
}
