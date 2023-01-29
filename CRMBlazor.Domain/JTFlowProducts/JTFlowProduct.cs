using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Flows;
using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.JTFlowProducts
{
    public sealed class JTFlowProduct : AggregateRoot<(FlowId, ProductId)>
    {
        public static JTFlowProduct Create(FlowId flowId, ProductId productId)
        {
            return new JTFlowProduct(flowId, productId);
        }

        private JTFlowProduct(FlowId flowId, ProductId productId) : base((flowId, productId))
        {
            FlowId = flowId;
            ProductId = productId;
        }

        public FlowId FlowId { get; }
        public ProductId ProductId { get; }
        private JTFlowProduct() { }
    }
}
