using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Companies.ValueObjects
{
    public sealed class CompanyId : ValueObject
    {

        public Guid Value { get; }


        private CompanyId(Guid value)
        {
            Value = value;
        }

        public static CompanyId CreateUnique()
        {
            return new CompanyId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private CompanyId() { }
    }
}
