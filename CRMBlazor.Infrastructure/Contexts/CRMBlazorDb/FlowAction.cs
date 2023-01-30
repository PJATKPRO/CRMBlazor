namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb
{
    public partial class FlowAction
    {
        public FlowAction()
        {
            JTEmailSnippets = new HashSet<JTFlowActionEmailSnippet>();
        }

        public int Id { get; set; }
        public int FlowCategoryId { get; set; }
        public FlowActionType Type { get; set; }
        public virtual ICollection<JTFlowActionEmailSnippet> JTEmailSnippets { get; set; } = null!;
        public virtual FlowCategory Category { get; set; }

    }

    public enum FlowActionType
    {
        None, SendEmail
    }
}
