namespace BiggerAndSmallerClassLibrary
{
    public class BiggerAndSmaller
    {
        public Product Smaller { get; private set; }
        public Product Bigger { get; private set; }

        public void Find(Cart cart)
        {
            foreach (Product product in cart.Products)
            {
                if (Smaller == null || product.Price < Smaller.Price)
                {
                    Smaller = product;
                }
                if (Bigger == null || product.Price > Bigger.Price)
                {
                    Bigger = product;
                }
            }
        }
    }
}