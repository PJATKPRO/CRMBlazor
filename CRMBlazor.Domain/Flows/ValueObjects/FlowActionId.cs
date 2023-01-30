using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows.ValueObjects
{
    public sealed class FlowActionId : ValueObject
    {

        public Guid Value { get; }


        private FlowActionId(Guid value)
        {
            Value = value;
        }

        public static FlowActionId CreateUnique()
        {
            return new FlowActionId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private FlowActionId() { }
    }
}
