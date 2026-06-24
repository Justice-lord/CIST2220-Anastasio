using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class HourlyEmployee:Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee():this ("","",15.0m)
        {
        }

        public HourlyEmployee(string firstname, string lastname, decimal hourlyRate):base(firstname, lastname)
        {
            HourlyRate = hourlyRate;
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + HourlyRate + " per hour.";
            }
        }

        public override decimal pay(int start, int end)
        {
            double hours = 0;

            for (int day = start; day < end; day++)
            {
                hours += Hours[day];
            }
            return (decimal) hours * HourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
