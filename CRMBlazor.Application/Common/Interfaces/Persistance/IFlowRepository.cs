using CRMBlazor.Domain.Clients.ValueObjects;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Flows;
using CRMBlazor.Domain.Flows.Entities;
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
        Task<Flow> ChangeFlowCategory(FlowId flowId, FlowCategoryId flowCategoryId);


        Task<FlowCategory> CreateFlowCategory(FlowCategoryId id, string name, string? description, Color color);
        Task<FlowCategory> GetFlowCategory(FlowCategoryId id);
        Task<IReadOnlyList<FlowCategory>> GetAllFlowCategories();
        Task AddFlowCategory(FlowCategory flowCategory);
        Task DeleteFlowCategory(FlowCategoryId id);
        Task UpdateFlowCategory(FlowCategory flowCategory);
        Task<Flow> ChangeFlowAction(FlowCategoryId flowCategoryId, FlowActionId flowActionId);


        Task<FlowAction> CreateFlowAction(FlowActionId id, string type);
        Task<FlowAction> GetFlowAction(FlowActionId id);
        Task<IReadOnlyList<FlowAction>> GetAllFlowActions();
        Task AddFlowAction(FlowAction flowAction);
        Task DeleteFlowAction(FlowActionId id);
        Task UpdateFlowAction(FlowAction flowAction);


    }
}
