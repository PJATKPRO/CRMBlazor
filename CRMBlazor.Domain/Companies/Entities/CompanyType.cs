using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Companies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Companies.Entities
{
    public sealed class CompanyType : AggregateRoot<CompanyTypeId>
    {

        public static CompanyType Create(CompanyTypeId id, string name, string? description)
        {
            return new CompanyType(id, name, description);
        }

        private CompanyType(CompanyTypeId id, string name, string? description) : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }
        public string? Description { get; }

        private CompanyType() { }

    }
}
