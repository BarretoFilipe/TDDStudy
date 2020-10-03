namespace SalaryCalculationClassLibrary
{
    public class TenOrTwentyPercentage : ISalaryCalculationRules
    {
        public decimal Calculation(Employee employee)
        {
            if (employee.Salary > 3000)
                return employee.Salary * 0.8m;
            return employee.Salary * 0.9m;
        }
    }
}