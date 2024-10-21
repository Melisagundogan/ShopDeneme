using shopapp.entity;
using System.Collections.Generic;

namespace Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; } = null!;
        public List<Category> Categories { get; set; } = null!;
    }
}
