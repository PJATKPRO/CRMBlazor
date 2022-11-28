using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Server.Data.CRMBlazorDb.Config
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
