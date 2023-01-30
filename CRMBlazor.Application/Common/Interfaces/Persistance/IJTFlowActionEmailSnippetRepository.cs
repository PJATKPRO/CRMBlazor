using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using CRMBlazor.Domain.Flows.ValueObjects;
using CRMBlazor.Domain.JTFlowActionEmailSnippets;
using CRMBlazor.Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface IJTFlowActionEmailSnippetRepository
    {
        Task<JTFlowActionEmailSnippet> Create(FlowActionId flowActionId, EmailSnippetId emailSnippetId);
        Task<JTFlowActionEmailSnippet> Get((FlowActionId flowActionId, EmailSnippetId emailSnippetId) id);
        Task<IReadOnlyList<JTFlowActionEmailSnippet>> GetAll();
        Task Add(JTFlowActionEmailSnippet jTFlowActionEmailSnippet);
        Task Delete((FlowActionId flowActionId, EmailSnippetId emailSnippetId) id);

    }
}
