using BiggerAndSmallerClassLibrary;
using NUnit.Framework;

namespace BiggerAndSmallerUnitTest
{
    public class BiggerAndSmallerTest
    {
        [Test]
        public void DescendingOrder()
        {
            var cart = new CartBuilder()
                .WithItens(450.0m, 250.0m, 70.0m)
                .Create();

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(70.0m, algorithm.Smaller.Price);
            Assert.AreEqual(450.0m, algorithm.Bigger.Price);
        }

        [Test]
        public void AscendingOrder()
        {
            var cart = new CartBuilder()
                .WithItens(70.0m, 250.0m, 450.0m)
                .Create();

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(70.0m, algorithm.Smaller.Price);
            Assert.AreEqual(450.0m, algorithm.Bigger.Price);
        }

        [Test]
        public void RandomOrder()
        {
            var cart = new CartBuilder()
                .WithItens(450.0m, 70.0m, 250.0m)
                .Create();

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(70.0m, algorithm.Smaller.Price);
            Assert.AreEqual(450.0m, algorithm.Bigger.Price);
        }

        [Test]
        public void SingleItem()
        {
            var cart = new CartBuilder()
                .WithItens(250.0m)
                .Create();

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(250.0m, algorithm.Smaller.Price);
            Assert.AreEqual(250.0m, algorithm.Bigger.Price);
        }
    }
}