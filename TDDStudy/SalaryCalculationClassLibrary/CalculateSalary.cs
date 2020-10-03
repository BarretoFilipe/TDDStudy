namespace SalaryCalculationClassLibrary
{
    public class CalculateSalary
    {
        public decimal Calculate(Employee employee)
        {
            return employee.Role.SalaryCalculationRules.Calculation(employee);
        }
    }
}