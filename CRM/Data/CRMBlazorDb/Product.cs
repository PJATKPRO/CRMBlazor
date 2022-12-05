using System.ComponentModel;

namespace CRMBlazor.Data.CRMBlazorDb
{
    public partial class Product
    {

        public Product()
        {
            JTFlows = new HashSet<JTFlowProduct>();
        }
        public int Id { get; set; }
        [DisplayName("Nazwa Produktu")]
        public string ProductName { get; set; }
        [DisplayName("Firma")]
        public string? Company { get; set; }
        [DisplayName("Opis")]
        public string? Description { get; set; }
        [DisplayName("Cena zakupu")]
        public decimal PurchasePrice { get; set; }
        [DisplayName("Cena Sprzedaży")]
        public decimal SellingPrice { get; set; }
        [DisplayName("Gwarancja (lat)")]
        public int Warranty { get; set; }
        public int CategoryId { get; set; }
        public int? WarehouseId { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual ICollection<JTFlowProduct> JTFlows { get; set; }
        public virtual ProductCategory Category { get; set; }
    }
}
