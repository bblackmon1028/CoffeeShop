using System.ComponentModel;

namespace CoffeeShop.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Product Description")]
        public string Description { get; set; }
        public string Category { get; set;  }

        public double Price { get; set; }
    }
}
