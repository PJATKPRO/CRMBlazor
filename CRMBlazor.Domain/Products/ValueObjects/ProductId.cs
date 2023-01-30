using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Products.ValueObjects
{
    public sealed class ProductId : ValueObject
    {
        public Guid Value { get; }


        private ProductId(Guid value)
        {
            Value = value;
        }

        public static ProductId CreateUnique()
        {
            return new ProductId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private ProductId() { }
    }
}
