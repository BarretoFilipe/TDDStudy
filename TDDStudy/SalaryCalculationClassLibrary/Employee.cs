namespace SalaryCalculationClassLibrary
{
    public class Employee
    {
        public Employee(string name, decimal salary, Role role)
        {
            Name = name;
            Salary = salary;
            Role = role;
        }

        public string Name { get; private set; }
        public decimal Salary { get; private set; }
        public Role Role { get; private set; }
    }
}