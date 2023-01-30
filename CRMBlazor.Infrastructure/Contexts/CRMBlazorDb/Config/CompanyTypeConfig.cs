using CRMBlazor.Infrastructure.Contexts.CRMBlazorDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb.Config
{
    internal sealed class CompanyTypeConfig : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure
            (EntityTypeBuilder<CompanyType> entity)
        {
            entity.HasKey(e => e.Id);

        }
    }
}
