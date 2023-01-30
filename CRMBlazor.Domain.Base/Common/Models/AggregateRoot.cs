using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Base.Common.Models
{
    public abstract class AggregateRoot<TId> : Entity<TId>
    where TId : notnull
    {
        protected AggregateRoot(TId id) : base(id)
        {
        }

        protected AggregateRoot()
            : base()
        {
        }
    }
}
