namespace SalaryCalculationClassLibrary
{
    public class FifteenOrTwentyFivePercentage : ISalaryCalculationRules
    {
        public decimal Calculation(Employee employee)
        {
            if (employee.Salary > 2500)
                return employee.Salary * 0.75m;
            return employee.Salary * 0.85m;
        }
    }
}