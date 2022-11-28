using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Server.Data.CRMBlazorDb.Config
{
    internal sealed class JTFlowProductConfig : IEntityTypeConfiguration<JTFlowProduct>
    {
        public void Configure
            (EntityTypeBuilder<JTFlowProduct> entity)
        {
            entity.HasKey(e => new { e.FlowId, e.ProductId });


            entity.HasOne(d => d.Flow)
                .WithMany(p => p.JTProducts)
                .HasForeignKey(d => d.FlowId);

            entity.HasOne(d => d.Product)
                .WithMany(p => p.JTFlows)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
