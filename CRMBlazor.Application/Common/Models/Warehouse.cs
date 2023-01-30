using CRMBlazor.Application.Common.Models;

namespace CRMBlazor.Data.CRMBlazorDb
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Flows = new HashSet<Flow>();
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Address? Address { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Flow> Flows { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
