using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class Employee
    {
        private static int LastEmpNum =0;
        public int EmpNum { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<double> hours = new List<double>();

        public List<double> Hours
        {
            get {  return hours; }
            set { hours = value; }
        }

        public Employee()
        {
            EmpNum = LastEmpNum++;
        }

        public Employee(string firstname, string lastname):this()
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public abstract string PaySummary
        {
            get;
        }

        public abstract Decimal pay(int start , int end);

        public override string ToString()
        {
            return $"{EmpNum} {FirstName} {LastName}";
        }
    }
}
