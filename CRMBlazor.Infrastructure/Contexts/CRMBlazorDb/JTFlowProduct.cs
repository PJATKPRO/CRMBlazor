namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb
{
    public partial class JTFlowProduct
    {
        public int FlowId { get; set; }
        public int ProductId { get; set; }
        public int Quanity { get; set; }

        public virtual Flow Flow { get; set; }
        public virtual Product Product { get; set; }

    }
}
