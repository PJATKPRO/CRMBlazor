using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Warehouses
{
    public sealed class Warehouse : AggregateRoot<WarehouseId>
    {

        public static Warehouse Create(WarehouseId id, string name, Address address)
        {
            return new Warehouse(id, name, address);
        }

        private Warehouse(WarehouseId id, string name, Address address) : base(id)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; } = null!;
        public Address Address { get; private set; } = null!;

        private Warehouse() { }


    }
}
