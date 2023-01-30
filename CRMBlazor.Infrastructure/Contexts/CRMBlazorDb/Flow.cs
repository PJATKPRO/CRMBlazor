namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb
{
    public partial class Flow
    {
        public Flow()
        {
            JTProducts = new HashSet<JTFlowProduct>();
        }
        public int Id { get; set; }
        public int OfferNr { get; set; }
        public string? InstallationName { get; set; }
        public string? Description { get; set; }
        public string? FirePrevention { get; set; }
        public string ConstructionType { get; set; }
        public string? EVCharger { get; set; }
        public string? EVChargerCounter { get; set; }
        public DateOnly InstallationDate { get; set; }
        public bool IsActive { get; set; } = true;
        public string? ModulesWholesale { get; set; }
        public string? OptimiserWholesale { get; set; }
        public string? ChargerWholesale { get; set; }
        public string? EnergyStorageWholesale { get; set; }
        public int? WarehouseId { get; set; }
        public int ClientId { get; set; }
        public int CategoryId { get; set; }



        public virtual ICollection<JTFlowProduct> JTProducts { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual Client Client { get; set; }
        public virtual FlowCategory Category { get; set; }

    }
}
