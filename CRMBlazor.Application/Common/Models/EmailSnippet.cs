namespace CRMBlazor.Data.CRMBlazorDb
{
    public partial class EmailSnippet
    {
        public EmailSnippet()
        {
            JTFlowActions = new HashSet<JTFlowActionEmailSnippet>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Header { get; set; }
        public string Content { get; set; }
        public string? Footer { get; set; }

        public virtual ICollection<JTFlowActionEmailSnippet> JTFlowActions { get; set; }
    }
}
