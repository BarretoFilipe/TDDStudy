namespace SalaryCalculationClassLibrary
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual decimal CalculateSalary()
        {
            if (Salary > 2500)
                return Salary * 0.75m;
            return Salary * 0.85m;
        }
    }
}