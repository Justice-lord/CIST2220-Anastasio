using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    internal class Employee
    {
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }
    }
}
