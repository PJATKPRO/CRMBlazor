using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Flows.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.JTFlowActionEmailSnippets
{
    public sealed class JTFlowActionEmailSnippet : AggregateRoot<(FlowActionId, EmailSnippetId)>
    {

        public static JTFlowActionEmailSnippet Create(FlowActionId flowActionId, EmailSnippetId emailSnippetId)
        {
            return new JTFlowActionEmailSnippet(flowActionId, emailSnippetId);
        }

        private JTFlowActionEmailSnippet(FlowActionId flowActionId, EmailSnippetId emailSnippetId) : base((flowActionId, emailSnippetId))
        {
            FlowActionId = flowActionId;
            EmailSnippetId = emailSnippetId;
        }

        public FlowActionId FlowActionId { get; }
        public EmailSnippetId EmailSnippetId { get; }
        private JTFlowActionEmailSnippet() { }
    }
}
