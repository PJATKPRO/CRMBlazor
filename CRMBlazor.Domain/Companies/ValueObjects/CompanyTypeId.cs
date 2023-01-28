using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Companies.ValueObjects
{
    public sealed class CompanyTypeId : ValueObject
    {

        public Guid Value { get; }


        private CompanyTypeId(Guid value)
        {
            Value = value;
        }

        public static CompanyTypeId CreateUnique()
        {
            return new CompanyTypeId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private CompanyTypeId() { }
    }
}
