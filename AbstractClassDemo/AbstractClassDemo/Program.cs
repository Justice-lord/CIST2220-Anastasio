using AbstractClassDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourEmp = new HourlyEmployee("Bill", "Gates", 15.0m);
            hourEmp.Hours.Add(80.0);
            hourEmp.Hours.Add(90.0);
            hourEmp.Hours.Add(70.0);

            SalaryEmployee salaryEmp = new SalaryEmployee("Alan", "Turing", 40000.0m);
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);

            List<Employee> myEmployees = new List<Employee>();
            myEmployees.Add(hourEmp);
            myEmployees.Add(salaryEmp);
            decimal payroll = 0;

            foreach (Employee e in myEmployees)
            {
                payroll += e.pay(0, 3);
            }

            DisplayEmpInfo(hourEmp, 0, 3);
            DisplayEmpInfo(salaryEmp, 0, 3);

            Console.WriteLine("Payroll total for 0-2: " + payroll.ToString());

            foreach (Employee employee in myEmployees)
            {
                Console.WriteLine("Employee: " + employee);
                if (employee is HourlyEmployee)
                {
                    HourlyEmployee hourlyEmp = (HourlyEmployee)employee;
                    Console.WriteLine("Hourly rate: " + hourlyEmp.HourlyRate); 
                }
                if (employee is SalaryEmployee)
                {
                    SalaryEmployee salEmp = employee as SalaryEmployee;
                    Console.WriteLine("Salary: " + salEmp.Salary);
                }
            }
        }

        private static void DisplayEmpInfo(Employee emp, int payStart, int payEnd)
        {
            Console.WriteLine($"hourEmp.GetHashCode: {emp.GetHashCode()}");
            Console.WriteLine($"hourEmp.GetType: {emp.GetType()}");
            Console.WriteLine($"hourEmp.ToString: {emp.ToString()}");
            Console.WriteLine($"hourEmp.GetPaySummary: {emp.PaySummary}");
            Console.WriteLine($"Pay for periods 0-2: {emp.pay(payStart, payEnd).ToString("c")}");
            Console.WriteLine();
        }
    }
}
