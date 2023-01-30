using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Companies.ValueObjects;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Products;
using CRMBlazor.Domain.Products.Entities;
using CRMBlazor.Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface IProductRepository
    {
        Task<Product> CreateProduct(ProductId id, string productName, string? company, string? description, Price purchasePrice, Price sellingPrice, int warranty);
        Task<Product> GetProduct(ProductId id);
        Task<IReadOnlyList<Product>> GetAllProducts();
        Task AddProduct(Product company);
        Task DeleteProduct(ProductId id);
        Task UpdateProduct(Product company);


        Task<ProductCategory> CreateCategory(ProductCategoryId id, string name, string description);
        Task<ProductCategory> GetCategory(ProductCategoryId id);
        Task<IReadOnlyList<ProductCategory>> GetAllCategories();
        Task AddCategory(ProductCategory company);
        Task DeleteCategory(ProductCategoryId id);
        Task UpdateCategory(ProductCategory company);
    }
}
