using NUnit.Framework;
using SalaryCalculationClassLibrary;

namespace SalaryCalculationUnitTest
{
    public class SalaryCalculationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryBelowTheLimit()
        {
            var developer = new Developer("Filipe", 1500.0m);

            var salary = developer.CalculateSalary();

            Assert.AreEqual(developer.Salary * 0.9m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryAboveTheLimit()
        {
            var developer = new Developer("Filipe", 4000.0m);

            var salary = developer.CalculateSalary();

            Assert.AreEqual(developer.Salary * 0.8m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForTestersWithSalaryBelowTheLimit()
        {
            var tester = new Tester("José", 1500.0m);

            var salary = tester.CalculateSalary();

            Assert.AreEqual(tester.Salary * 0.85m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForTestersWithSalaryAboveTheLimit()
        {
            var tester = new Tester("José", 4000.0m);

            var salary = tester.CalculateSalary();

            Assert.AreEqual(tester.Salary * 0.75m, salary);
        }
    }
}