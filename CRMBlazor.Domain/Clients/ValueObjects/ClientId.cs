using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Clients.ValueObjects
{
    public sealed class ClientId : ValueObject
    {
        public Guid Value { get; }


        private ClientId(Guid value)
        {
            Value = value;
        }

        public static ClientId CreateUnique()
        {
            return new ClientId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private ClientId() { }

    }
}
