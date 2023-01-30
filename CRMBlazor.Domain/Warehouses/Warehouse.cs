using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Companies;
using CRMBlazor.Domain.Companies.ValueObjects;
using CRMBlazor.Domain.Products;
using CRMBlazor.Domain.Products.ValueObjects;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRMBlazor.Domain.Warehouses
{
    public sealed class Warehouse : AggregateRoot<WarehouseId>
    {

        public static Warehouse Create(WarehouseId id, string name, Address address, CompanyId companyId)
        {
            return new Warehouse(id, name, address, companyId);
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _products.Remove(product);
        }

        public void DeleteProduct(ProductId id)
        {
            //singleOrDefault also checks for duplicates and throws exception, but bit slower
            var product = _products.SingleOrDefault(x => x.Id == id);
            _products.Remove(product);
        }

        private Warehouse(WarehouseId id, string name, Address address, CompanyId companyId) : base(id)
        {
            Name = name;
            Address = address;
            CompanyId = companyId;
        }



        private List<Product> _products = new List<Product>();
        public IReadOnlyList<Product> Products => _products.AsReadOnly();
        public string Name { get; } = null!;
        public Address Address { get; private set; } = null!;
        public CompanyId CompanyId { get; }

        private Warehouse() { }


    }
}
