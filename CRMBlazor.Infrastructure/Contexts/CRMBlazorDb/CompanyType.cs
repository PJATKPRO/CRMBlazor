using CRMBlazor.Infrastructure.Contexts.CRMBlazorDb;

namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb
{
    public partial class CompanyType
    {

        public CompanyType()
        {
            Companies = new HashSet<Company>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
