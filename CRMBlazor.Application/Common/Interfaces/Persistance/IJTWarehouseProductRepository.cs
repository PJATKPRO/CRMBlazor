using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.JTWarehouseProducts;
using CRMBlazor.Domain.Products.ValueObjects;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface IJTWarehouseProductRepository
    {
        Task<JTWarehouseProduct> Create(WarehouseId warehouseId, ProductId productId);
        Task<JTWarehouseProduct> Get((WarehouseId warehouseId, ProductId productId) id);
        Task<IReadOnlyList<JTWarehouseProduct>> GetAll();
        Task Add(JTWarehouseProduct jTWarehouseProduct);
        Task Delete((WarehouseId warehouseId, ProductId productId) id);
        Task UpdateAmmount((WarehouseId warehouseId, ProductId productId) id, int ammount);
    }
}
