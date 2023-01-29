using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Products.ValueObjects;
using CRMBlazor.Domain.Warehouses;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CRMBlazor.Domain.Products
{
    public sealed class Product : AggregateRoot<ProductId>
    {


        public static Product Create(ProductId id, string productName, string? company, string? description, Price purchasePrice, Price sellingPrice, int warranty)
        {
            return new Product(id, productName, company, description, purchasePrice, sellingPrice, warranty);
        }

        public void UpdatePurchasePrice(Price price)
        {
            PurchasePrice = price;
        }

        public void UpdateSellingPrice(Price price)
        {
            SellingPrice = price;
        }


        private Product(ProductId id, string productName, string? company, string? description, Price purchasePrice, Price sellingPrice, int warranty) : base(id)
        {
            ProductName = productName;
            Company = company;
            Description = description;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            Warranty = warranty;
        }


        public string ProductName { get; }
        public string? Company { get; }
        public string? Description { get; }
        public Price PurchasePrice { get; private set; }
        public Price SellingPrice { get; private set; }
        public int Warranty { get; }

        private Product() { }


    }
}
