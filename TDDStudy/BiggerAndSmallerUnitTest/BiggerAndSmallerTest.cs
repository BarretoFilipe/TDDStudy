using BiggerAndSmallerClassLibrary;
using NUnit.Framework;

namespace BiggerAndSmallerUnitTest
{
    public class BiggerAndSmallerTest
    {
        private readonly Product fridge = new Product("Fridge", 450.0m);
        private readonly Product blender = new Product("Blender", 250.0m);
        private readonly Product dinnerwareSets = new Product("Dinnerware Sets", 70.0m);

        [Test]
        public void DescendingOrder()
        {
            var cart = new Cart();
            cart.Add(fridge);
            cart.Add(blender);
            cart.Add(dinnerwareSets);

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(dinnerwareSets, algorithm.Smaller);
            Assert.AreEqual(fridge, algorithm.Bigger);
        }

        [Test]
        public void AscendingOrder()
        {
            var cart = new Cart();
            cart.Add(dinnerwareSets);
            cart.Add(blender);
            cart.Add(fridge);

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(dinnerwareSets, algorithm.Smaller);
            Assert.AreEqual(fridge, algorithm.Bigger);
        }

        [Test]
        public void RandomOrder()
        {
            var cart = new Cart();
            cart.Add(fridge);
            cart.Add(dinnerwareSets);
            cart.Add(blender);

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(dinnerwareSets, algorithm.Smaller);
            Assert.AreEqual(fridge, algorithm.Bigger);
        }

        [Test]
        public void SingleItem()
        {
            var cart = new Cart();

            cart.Add(fridge);

            var algorithm = new BiggerAndSmaller();
            algorithm.Find(cart);

            Assert.AreEqual(fridge, algorithm.Smaller);
            Assert.AreEqual(fridge, algorithm.Bigger);
        }
    }
}