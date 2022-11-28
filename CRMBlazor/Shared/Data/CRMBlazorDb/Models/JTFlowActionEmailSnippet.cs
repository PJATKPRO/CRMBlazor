namespace CRMBlazor.Shared.Data.CRMBlazorDb.Models
{
    public partial class JTFlowActionEmailSnippet
    {
        public int FlowActionId { get; set; }
        public int EmailSnippetId { get; set; }

        public virtual FlowAction FlowAction { get; set; }
        public virtual EmailSnippet EmailSnippet { get; set; }
    }
}
