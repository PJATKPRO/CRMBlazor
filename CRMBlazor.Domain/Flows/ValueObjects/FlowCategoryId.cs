using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows.ValueObjects
{
    public sealed class FlowCategoryId : ValueObject
    {

        public Guid Value { get; }


        private FlowCategoryId(Guid value)
        {
            Value = value;
        }

        public static FlowCategoryId CreateUnique()
        {
            return new FlowCategoryId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private FlowCategoryId() { }
    }
}
