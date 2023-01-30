using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Clients.ValueObjects;
using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows
{
    public partial class Flow : AggregateRoot<FlowId>
    {

        public static Flow Create(FlowId id,
                                  int offerNr,
                                  string? installationName,
                                  string? description,
                                  string? firePrevention,
                                  string constructionType,
                                  string? eVCharger,
                                  string? eVChargerCounter,
                                  DateTime installationDate,
                                  bool isActive,
                                  string? modulesWholesale,
                                  string? optimiserWholesale,
                                  string? chargerWholesale,
                                  string? energyStorageWholesale,
                                  WarehouseId? warehouseId,
                                  ClientId clientId,
                                  FlowCategoryId categoryId)
        {
            return new Flow(id,
                            offerNr,
                            installationName,
                            description,
                            firePrevention,
                            constructionType,
                            eVCharger,
                            eVChargerCounter,
                            installationDate,
                            isActive,
                            modulesWholesale,
                            optimiserWholesale,
                            chargerWholesale,
                            energyStorageWholesale,
                            warehouseId,
                            clientId,
                            categoryId);
        }

        private Flow(FlowId id, int offerNr,
                    string? installationName,
                    string? description,
                    string? firePrevention,
                    string constructionType,
                    string? eVCharger,
                    string? eVChargerCounter,
                    DateTime installationDate,
                    bool isActive,
                    string? modulesWholesale,
                    string? optimiserWholesale,
                    string? chargerWholesale,
                    string? energyStorageWholesale,
                    WarehouseId? warehouseId,
                    ClientId clientId,
                    FlowCategoryId categoryId) : base(id)
        {
            OfferNr = offerNr;
            InstallationName = installationName;
            Description = description;
            FirePrevention = firePrevention;
            ConstructionType = constructionType;
            EVCharger = eVCharger;
            EVChargerCounter = eVChargerCounter;
            InstallationDate = installationDate;
            IsActive = isActive;
            ModulesWholesale = modulesWholesale;
            OptimiserWholesale = optimiserWholesale;
            ChargerWholesale = chargerWholesale;
            EnergyStorageWholesale = energyStorageWholesale;
            WarehouseId = warehouseId;
            ClientId = clientId;
            CategoryId = categoryId;

        }

        public int OfferNr { get; }
        public string? InstallationName { get; private set; }
        public string? Description { get; private set; }
        public string? FirePrevention { get; private set; }
        public string ConstructionType { get; private set; }
        public string? EVCharger { get; private set; }
        public string? EVChargerCounter { get; private set; }
        public DateTime InstallationDate { get; private set; }
        public bool IsActive { get; private set; } = true;
        public string? ModulesWholesale { get; private set; }
        public string? OptimiserWholesale { get; private set; }
        public string? ChargerWholesale { get; private set; }
        public string? EnergyStorageWholesale { get; private set; }
        public WarehouseId? WarehouseId { get; private set; }
        public ClientId ClientId { get; private set; }
        public FlowCategoryId CategoryId { get; private set; }


        private Flow() { }




    }
}
