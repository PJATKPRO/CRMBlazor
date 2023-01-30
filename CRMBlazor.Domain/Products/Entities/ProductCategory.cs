using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Products.Entities
{
    public sealed class ProductCategory : Entity<ProductCategoryId>
    {

        public static ProductCategory Create(ProductCategoryId id, string name, string description)
        {
            return new ProductCategory(id, name, description);
        }

        private ProductCategory(ProductCategoryId id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;

        }


        public string Name { get; }
        public string? Description { get; }

        private ProductCategory() { }
    }
}
