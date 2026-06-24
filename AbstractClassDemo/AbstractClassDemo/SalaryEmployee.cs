using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary {  get; set; }

        public SalaryEmployee() : this ("","",30000.0m)
        {
        }

        public SalaryEmployee(string firstName, string lastName, decimal salary) : base (firstName, lastName)
        {
            Salary = salary;
        }

        public override string PaySummary
        {
            get
            {
                return $"This employee is payed {Salary} per year";
            }
        }

        public override decimal pay(int start, int end)
        {
            const int payPeriodsPerYear = 24;
            decimal pay = Salary * (end - start) / payPeriodsPerYear;
            return pay;
        }

        public override string ToString()
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
