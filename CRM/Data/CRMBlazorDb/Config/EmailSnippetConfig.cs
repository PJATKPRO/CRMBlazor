using CRMBlazor.Data.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Data.CRMBlazorDb.Config
{
    internal sealed class EmailSnippetConfig : IEntityTypeConfiguration<EmailSnippet>
    {
        public void Configure
            (EntityTypeBuilder<EmailSnippet> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Header).HasMaxLength(1024).IsRequired(false);
            entity.Property(e => e.Footer).HasMaxLength(1024).IsRequired(false);

        }
    }
}
