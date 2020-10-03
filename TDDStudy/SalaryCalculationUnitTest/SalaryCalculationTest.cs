using NUnit.Framework;
using SalaryCalculationClassLibrary;

namespace SalaryCalculationUnitTest
{
    public class SalaryCalculationTest
    {
        private CalculateSalary calculateSalary;

        [SetUp]
        public void Setup()
        {
            calculateSalary = new CalculateSalary();
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryBelowTheLimit()
        {
            var employee = new Employee("Filipe", 1500.0m, Role.Developer);

            var salary = calculateSalary.Calculate(employee);

            Assert.AreEqual(employee.Salary * 0.9m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryAboveTheLimit()
        {
            var employee = new Employee("Filipe", 4000.0m, Role.Developer);

            var salary = calculateSalary.Calculate(employee);

            Assert.AreEqual(employee.Salary * 0.8m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryEqualsTheLimit()
        {
            var employee = new Employee("Filipe", 3000.0m, Role.Developer);

            var salary = calculateSalary.Calculate(employee);

            Assert.AreEqual(employee.Salary * 0.9m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForTestersWithSalaryBelowTheLimit()
        {
            var employee = new Employee("José", 1500.0m, Role.Tester);

            var salary = calculateSalary.Calculate(employee);

            Assert.AreEqual(employee.Salary * 0.85m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForTestersWithSalaryAboveTheLimit()
        {
            var employee = new Employee("José", 4000.0m, Role.Tester);

            var salary = calculateSalary.Calculate(employee);

            Assert.AreEqual(employee.Salary * 0.75m, salary);
        }

        [Test]
        public void ShouldCalculateSalaryForTestersWithSalaryEqualsTheLimit()
        {
            var employee = new Employee("José", 2500.0m, Role.Tester);

            var salary = calculateSalary.Calculate(employee);

            Assert.AreEqual(employee.Salary * 0.85m, salary);
        }
    }
}