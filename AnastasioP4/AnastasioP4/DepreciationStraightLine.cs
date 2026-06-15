/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 * Purpose : Find inventory value using depreciation calculators
 Date: 6/15/2026*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioP4
{
    internal class DepreciationStraightLine
    {
        // fields
        private string title;
        private DateTime itemIn;
        private DateTime itemOut;
        private decimal startValue;
        private decimal endValue;
        private int lifetime;
        private decimal annualDepreciation;

        // properties
        public string Title { get; set; }
        public DateTime ItemIn
        {
            get {  return itemIn; }
            set
            {
                itemIn = value;
                Calc();
            }
        }
        public DateTime ItemOut
        {
            get { return itemOut; }
            set
            {
                itemOut = value;
                Calc();
            }
        }
        public decimal StartValue
        {
            get { return startValue; }
            set
            {
                startValue = value;
                Calc();
            }
        }
        public decimal EndValue
        {
            get { return endValue; }
            set
            {
                endValue = value;
                Calc();
            }
        }
        public int Lifetime
        {
            get { return lifetime; }
            set
            {
                lifetime = value;
                Calc();
            }
        }
        public decimal AnnualDepreciation { get; set; }

        public virtual void Calc()
        {
            // find total depreciation
            if (Lifetime != 0)
            {
                AnnualDepreciation = (1 / Lifetime) * (StartValue - EndValue);
            }
        }

        public override string ToString()
        {
            return $"{Title} lot start value of {StartValue} and a end value of {EndValue} with a lifetime of {Lifetime} years";
        }
    }
}
