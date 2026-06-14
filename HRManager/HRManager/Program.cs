namespace HRManager
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmpNum = 1;
            employee.FirstName = "Steve";
            employee.LastName = "Jobs";

            HourlyEmployee hourEmployee = new HourlyEmployee();
            hourEmployee.EmpNum = 2;
            hourEmployee.FirstName = "Bill";
            hourEmployee.LastName = "Gates";
            hourEmployee.HourlyRate = 15.00M;

            Console.WriteLine($"emp.GetPaySummary: {employee.PaySummary}");
            Console.WriteLine($"hourEmpolyee.GetPaySummary: {hourEmployee.PaySummary}");

            Employee employee2 = hourEmployee;

            Console.WriteLine($"emp2.GetPaySummary: {employee2.PaySummary}");
        }
    }
}
