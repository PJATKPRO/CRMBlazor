using System.ComponentModel.DataAnnotations;

namespace CRMBlazor.Shared.Data.CRMBlazorDb.Models
{
    public partial class Company
    {
        public Company()
        {
            Warehouses = new HashSet<Warehouse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Address? Address { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Nip { get; set; }
        public string? Krs { get; set; }
        public string? Regon { get; set; }
        public string? AdditionalInfo { get; set; }
        public int CompanyTypeId { get; set; }


        public virtual CompanyType CompanyType { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
