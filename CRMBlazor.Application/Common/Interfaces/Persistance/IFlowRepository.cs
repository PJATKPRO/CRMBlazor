using CRMBlazor.Domain.Clients.ValueObjects;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Flows;
using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    public interface IFlowRepository
    {
        Task<Flow> Create(FlowId id,
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
                          FlowCategoryId categoryId);
        Task<Flow> Get(FlowId id);
        Task<IReadOnlyList<Flow>> GetAll();
        Task Add(Flow flow);
        Task Delete(FlowId id);
        Task Update(Flow flow);


    }
}
