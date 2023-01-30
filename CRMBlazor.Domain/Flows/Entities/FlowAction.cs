using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Flows.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows.Entities
{
    public sealed class FlowAction : Entity<FlowActionId>
    {

        public static FlowAction Create(FlowActionId id, string type)
        {
            return new FlowAction(id, type);
        }

        private FlowAction(FlowActionId id, string type) : base(id)
        {
            Type = type;
        }

        public string Type { get; } = null!;
        private FlowAction() { }
    }
}
