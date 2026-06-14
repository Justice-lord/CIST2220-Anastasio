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

            Employee emp = new Employee();
            emp.EmpNum =3;
            emp.FirstName = "Jobs";
            emp.LastName = "Steve";

            Console.WriteLine($"emp.GetHashCode: {emp.GetHashCode()}");
            Console.WriteLine($"emp.GetType: {emp.GetType()}");
            Console.WriteLine($"emp.ToString: {emp.ToString()}");

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 4;
            hourEmp.FirstName = "Gates";
            hourEmp.LastName = "Bill";
            hourEmp.HourlyRate = 15.00M;

            Console.WriteLine($"hourEmp.GetHashCde: {hourEmp.GetHashCode()}");
            Console.WriteLine($"hourEmp.GetType: {hourEmp.GetType()}");
            Console.WriteLine($"hourEmp.ToString: {hourEmp.ToString()}");

            object athing = hourEmp;
            Console.WriteLine("hourEmp.ToString: " + athing);

            if (athing is HourlyEmployee)
            {
                HourlyEmployee unboxedEmp = (HourlyEmployee)athing;
                Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            }

            if (athing is HourlyEmployee)
            {
                Employee unboxedEmp = (Employee)athing;
                Console.WriteLine("First Name: " + unboxedEmp.LastName);
            }
        }
    }
}
