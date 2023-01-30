using CRMBlazor.Infrastructure.Contexts.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb.Config
{
    internal sealed class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure
            (EntityTypeBuilder<ProductCategory> entity)
        {
            entity.HasKey(e => e.Id);
        }
    }
}
