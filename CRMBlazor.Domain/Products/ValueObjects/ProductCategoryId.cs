using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Products.ValueObjects
{
    public sealed class ProductCategoryId : ValueObject
    {
        public Guid Value { get; }


        private ProductCategoryId(Guid value)
        {
            Value = value;
        }

        public static ProductCategoryId CreateUnique()
        {
            return new ProductCategoryId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private ProductCategoryId() { }
    }
}
