namespace SalaryCalculationClassLibrary
{
    public class Role
    {
        private Role(ISalaryCalculationRules salaryCalculationRules)
        {
            SalaryCalculationRules = salaryCalculationRules;
        }

        public ISalaryCalculationRules SalaryCalculationRules { get; private set; }
        public static Role Developer { get { return new Role(new TenOrTwentyPercentage()); } }
        public static Role Dba { get { return new Role(new FifteenOrTwentyFivePercentage()); } }
        public static Role Tester { get { return new Role(new FifteenOrTwentyFivePercentage()); } }
    }
}