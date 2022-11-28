using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Server.Data.CRMBlazorDb.Config
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
