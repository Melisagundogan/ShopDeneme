
namespace shopapp.webui.ViewModels
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public double? Price { get; set; }
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public bool IsApproved { get; set; }
    }
}
