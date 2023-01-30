using CRMBlazor.Infrastructure.Contexts.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb.Config
{
    internal sealed class JTFlowActionEmailSnippetConfig : IEntityTypeConfiguration<JTFlowActionEmailSnippet>
    {
        public void Configure
            (EntityTypeBuilder<JTFlowActionEmailSnippet> entity)
        {
            entity.HasKey(e => new { e.EmailSnippetId, e.FlowActionId });


            entity.HasOne(d => d.FlowAction)
                .WithMany(p => p.JTEmailSnippets)
                .HasForeignKey(d => d.FlowActionId);

            entity.HasOne(d => d.EmailSnippet)
                .WithMany(p => p.JTFlowActions)
                .HasForeignKey(d => d.EmailSnippetId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
