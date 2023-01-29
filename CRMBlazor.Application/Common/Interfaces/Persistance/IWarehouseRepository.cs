using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Companies.ValueObjects;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Warehouses;
using CRMBlazor.Domain.Warehouses.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface IWarehouseRepository
    {
        Task<Warehouse> Create(WarehouseId id, string name, Address address, CompanyId companyId);
        Task<Warehouse> Get(WarehouseId id);
        Task<IReadOnlyList<Warehouse>> GetAll();
        Task Add(Warehouse company);
        Task Delete(WarehouseId id);
        Task Update(Warehouse company);
        Task UpdateAddress(Address address);
    }
}
