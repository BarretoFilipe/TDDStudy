using BiggerAndSmallerClassLibrary;

namespace BiggerAndSmallerUnitTest
{
    public class CartBuilder
    {
        public Cart cart;

        public CartBuilder()
        {
            cart = new Cart();
        }

        public CartBuilder WithItens(params decimal[] prices)
        {
            foreach (var price in prices)
            {
                cart.Add(new Product($"Item {cart.Products.Count + 1}", price));
            }
            return this;
        }

        public Cart Create()
        {
            return cart;
        }
    }
}