using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Warehouses.ValueObjects
{
    public sealed class WarehouseId : ValueObject
    {

        public Guid Value { get; }


        private WarehouseId(Guid value)
        {
            Value = value;
        }

        public static WarehouseId CreateUnique()
        {
            return new WarehouseId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private WarehouseId() { }
    }
}
