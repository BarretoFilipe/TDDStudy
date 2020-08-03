using System.Collections.Generic;

namespace BiggerAndSmallerClassLibrary
{
    public class Cart
    {
        public Cart()
        {
            Products = new List<Product>();
        }

        public List<Product> Products { get; set; }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}