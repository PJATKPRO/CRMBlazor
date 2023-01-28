using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Companies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.EmailSnippets.ValueObjects
{
    public sealed class EmailSnippetId : ValueObject
    {
        public Guid Value { get; }


        private EmailSnippetId(Guid value)
        {
            Value = value;
        }

        public static EmailSnippetId CreateUnique()
        {
            return new EmailSnippetId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }


        private EmailSnippetId() { }

    }
}
