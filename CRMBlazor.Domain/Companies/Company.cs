using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Companies.Entities;
using CRMBlazor.Domain.Companies.ValueObjects;
using CRMBlazor.Domain.Warehouses;
using System.Collections.Generic;

namespace CRMBlazor.Domain.Companies
{
    public sealed class Company : AggregateRoot<CompanyId>
    {

        public static Company Create(CompanyId id, string name, string description, Address address, string? email, string? phone, string? nip, string? krs, string? regon, string? additionalInfo, CompanyTypeId typeId)
        {
            return new Company(id, name, description, address, email, phone, nip, krs, regon, additionalInfo, typeId);
        }

        private Company(CompanyId id, string name, string description, Address address, string? email, string? phone, string? nip, string? krs, string? regon, string? additionalInfo, CompanyTypeId typeId) : base(id)
        {
            Name = name;
            Description = description;
            Address = address;
            Email = email;
            Phone = phone;
            Nip = nip;
            Krs = krs;
            Regon = regon;
            AdditionalInfo = additionalInfo;
            TypeId = typeId;
        }




        private List<Warehouse> _warehouses = new List<Warehouse>();
        public IReadOnlyList<Warehouse> Warehouses => _warehouses.AsReadOnly();
        public string Name { get; } = null!;
        public string Description { get; private set; }
        public Address Address { get; private set; }
        public string? Email { get; private set; }
        public string? Phone { get; private set; }
        public string? Nip { get; }
        public string? Krs { get; }
        public string? Regon { get; }
        public string? AdditionalInfo { get; private set; }
        public CompanyTypeId TypeId { get; }

    }
}
