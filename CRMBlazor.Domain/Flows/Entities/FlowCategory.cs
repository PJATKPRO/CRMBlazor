using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Flows.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Flows.Entities
{
    public sealed class FlowCategory : Entity<FlowCategoryId>
    {


        public static FlowCategory Create(FlowCategoryId id, string name, string? description, Color color)
        {
            return new FlowCategory(id, name, description, color);
        }
        private FlowCategory(FlowCategoryId id, string name, string? description, Color color) : base(id)
        {
            Name = name;
            Description = description;
            Color = color;
        }


        private List<FlowAction> _actions = new List<FlowAction>();
        private List<Flow> _flows = new List<Flow>();
        public IReadOnlyCollection<FlowAction> FlowActions => _actions.AsReadOnly();
        public IReadOnlyCollection<Flow> Flows => _flows.AsReadOnly();
        public string Name { get; }
        public string? Description { get; }
        public Color Color { get; private set; }
        private FlowCategory() { }
    }
}
