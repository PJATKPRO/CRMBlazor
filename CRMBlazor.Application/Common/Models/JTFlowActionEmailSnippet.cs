namespace CRMBlazor.Data.CRMBlazorDb
{
    public partial class JTFlowActionEmailSnippet
    {
        public int FlowActionId { get; set; }
        public int EmailSnippetId { get; set; }

        public virtual FlowAction FlowAction { get; set; }
        public virtual EmailSnippet EmailSnippet { get; set; }
    }
}
