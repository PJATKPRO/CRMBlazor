using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows.ValueObjects
{
    public sealed class FlowId : ValueObject
    {

        public Guid Value { get; }


        private FlowId(Guid value)
        {
            Value = value;
        }

        public static FlowId CreateUnique()
        {
            return new FlowId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private FlowId() { }
    }
}
