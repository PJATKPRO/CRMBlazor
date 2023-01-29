using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.Products.ValueObjects;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.JTWarehouseProducts
{
    public sealed class JTWarehouseProduct : AggregateRoot<(WarehouseId, ProductId)>
    {
        public static JTWarehouseProduct Create(WarehouseId warehouseId, ProductId productId, int ammount)
        {
            return new JTWarehouseProduct(warehouseId, productId, ammount);
        }

        public void UpdateAmmount(int ammount)
        {
            ProductAmmount = ammount;
        }

        private JTWarehouseProduct(WarehouseId warehouseId, ProductId productId, int ammount) : base((warehouseId, productId))
        {
            WarehouseId = warehouseId;
            ProductId = productId;
            ProductAmmount = ammount;
        }

        public WarehouseId WarehouseId { get; }
        public ProductId ProductId { get; }
        public int ProductAmmount { get; private set; }
        private JTWarehouseProduct() { }
    }
}
