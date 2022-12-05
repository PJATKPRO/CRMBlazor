using CRMBlazor.Server.Models;
using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace CRMBlazor.Server.Data.CRMBlazorDb
{
    public partial class CRMBlazorDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public CRMBlazorDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<CRMBlazor.Shared.Data.CRMBlazorDb.Models.Client> Clients { get; set; } = default!;
        public DbSet<Company> Companies { get; set; } = default!;
        public DbSet<CompanyType> CompanyTypes { get; set; } = default!;
        public DbSet<EmailSnippet> EmailSnippets { get; set; } = default!;
        public DbSet<Flow> Flows { get; set; } = default!;
        public DbSet<FlowAction> FlowActions { get; set; } = default!;
        public DbSet<FlowCategory> FlowCategory { get; set; } = default!;
        public DbSet<JTFlowActionEmailSnippet> JTFlowActionEmailSnippets { get; set; } = default!;
        public DbSet<JTFlowProduct> JTFlowProducts { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = default!;
        public DbSet<Warehouse> Warehouses { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ignore owned types
            modelBuilder.Ignore<Address>();




            //use charset
            modelBuilder.HasCharSet("utf8mb4")
               .UseCollation("utf8mb4_general_ci");


            //define default config rules
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var entityProperty in entityType.GetProperties())
                {
                    if (entityProperty.ClrType == typeof(string)
                        && (
                        entityProperty.Name.Equals("Name")
                        || entityProperty.Name.Equals("Surname")
                        || entityProperty.Name.Contains("Email")
                        )
                        )
                    {
                        entityProperty.SetMaxLength(128);
                    }

                    if (entityProperty.ClrType == typeof(decimal)
                        && entityProperty.Name.Contains("Price"))
                    {
                        entityProperty.SetPrecision(9);
                        entityProperty.SetScale(2);
                    }

                    if (entityProperty.ClrType == typeof(string)
                        && entityProperty.Name.EndsWith("Url"))
                    {
                        entityProperty.SetIsUnicode(false);
                    }

                    if (entityProperty.ClrType == typeof(string)
                        && entityProperty.Name.Contains("Description"))
                    {
                        entityProperty.SetMaxLength(500);
                    }
                }
            }

            //then override it with specyfic config for each entity
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //load confing automaticly from assemblies

            OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }

}