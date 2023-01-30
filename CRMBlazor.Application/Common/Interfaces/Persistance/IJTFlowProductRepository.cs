using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.JTFlowProducts;
using CRMBlazor.Domain.Products.ValueObjects;


namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface IJTFlowProductRepository
    {
        Task<JTFlowProduct> Create(FlowId flowId, ProductId productId);
        Task<JTFlowProduct> Get((FlowId flowId, ProductId productId) id);
        Task<IReadOnlyList<JTFlowProduct>> GetAll();
        Task Add(JTFlowProduct jTFlowProduct);
        Task Delete((FlowId flowId, ProductId productId) id);
    }
}
