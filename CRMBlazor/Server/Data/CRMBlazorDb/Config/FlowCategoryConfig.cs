using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Server.Data.CRMBlazorDb.Config
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
