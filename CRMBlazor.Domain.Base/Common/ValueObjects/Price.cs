using CRMBlazor.Domain.Base.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Base.Common.ValueObjects
{
    public sealed class Price : ValueObject
    {
        public decimal Amount { get; }
        public string Currency { get; }

        private Price(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Price CreateNew(decimal amount, string currency)
        {
            return new Price(amount, currency);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
