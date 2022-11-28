namespace CRMBlazor.Shared.Data.CRMBlazorDb.Models
{
    public partial class FlowCategory
    {
        public FlowCategory()
        {
            Flows = new HashSet<Flow>();
            FlowAction = new HashSet<FlowAction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<FlowAction> FlowAction { get; set; }
        public virtual ICollection<Flow> Flows { get; set; }

    }
}
