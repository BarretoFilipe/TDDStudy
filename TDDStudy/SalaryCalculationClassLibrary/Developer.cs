namespace SalaryCalculationClassLibrary
{
    public sealed class Developer : Employee
    {
        public Developer(string name, decimal salary) : base(name, salary)
        {
        }

        public override decimal CalculateSalary()
        {
            if (Salary > 3000)
                return Salary * 0.8m;
            return Salary * 0.9m;
        }
    }
}