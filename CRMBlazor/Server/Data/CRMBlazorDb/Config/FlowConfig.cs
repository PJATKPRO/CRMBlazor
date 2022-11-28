using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMBlazor.Server.Data.CRMBlazorDb.Config
{
    internal sealed class FlowConfig : IEntityTypeConfiguration<Flow>
    {
        public void Configure
            (EntityTypeBuilder<Flow> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.InstallationName).HasMaxLength(128);
            entity.Property(e => e.FirePrevention).HasMaxLength(128);
            entity.Property(e => e.ConstructionType).HasMaxLength(128);
            entity.Property(e => e.EVCharger).HasMaxLength(128);
            entity.Property(e => e.EVChargerCounter).HasMaxLength(128);
            entity.Property(e => e.ModulesWholesale).HasMaxLength(256);
            entity.Property(e => e.OptimiserWholesale).HasMaxLength(256);
            entity.Property(e => e.ChargerWholesale).HasMaxLength(256);
            entity.Property(e => e.EnergyStorageWholesale).HasMaxLength(256);
            entity.HasOne(d => d.Warehouse).WithMany(p => p.Flows).HasForeignKey(d => d.WarehouseId);
            entity.HasOne(d => d.Client).WithMany(p => p.Flows).HasForeignKey(d => d.ClientId);
            entity.HasOne(d => d.Category).WithMany(p => p.Flows).HasForeignKey(d => d.CategoryId);

        }
    }
}
