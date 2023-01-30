namespace CRMBlazor.Data.CRMBlazorDb
{
    public partial class ProductCategory
    {

        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
