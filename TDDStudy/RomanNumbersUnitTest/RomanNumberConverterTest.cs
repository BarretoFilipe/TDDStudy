using NUnit.Framework;
using RomanNumbersClassLibrary;

namespace RomanNumbersUnitTest
{
    public class RomanNumberConverterTest
    {
        public void BuilderRomanNumberTest(string symbol, int value)
        {
            var romanNumberConverter = new RomanNumberConverter();
            var number = romanNumberConverter.Convert(symbol);

            Assert.AreEqual(value, number);
        }

        [Test]
        public void MustUnderstandSymbolI()
        {
            BuilderRomanNumberTest("I", 1);
        }

        [Test]
        public void MustUnderstandSymbolV()
        {
            BuilderRomanNumberTest("V", 5);
        }

        [Test]
        public void MustUnderstandSymbolX()
        {
            BuilderRomanNumberTest("X", 10);
        }

        [Test]
        public void MustUnderstandSymbolL()
        {
            BuilderRomanNumberTest("L", 50);
        }

        [Test]
        public void MustUnderstandSymbolC()
        {
            BuilderRomanNumberTest("C", 100);
        }

        [Test]
        public void MustUnderstandSymbolD()
        {
            BuilderRomanNumberTest("D", 500);
        }

        [Test]
        public void MustUnderstandSymbolM()
        {
            BuilderRomanNumberTest("M", 1000);
        }

        [Test]
        public void MustUnderstandSymbolXXII()
        {
            BuilderRomanNumberTest("XXII", 22);
        }

        [Test]
        public void MustUnderstandSymbolIX()
        {
            BuilderRomanNumberTest("IX", 9);
        }

        [Test]
        public void MustUnderstandSymbolXXIV()
        {
            BuilderRomanNumberTest("XXIV", 24);
        }
    }
}