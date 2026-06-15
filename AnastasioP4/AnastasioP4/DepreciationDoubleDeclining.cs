/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 * Purpose : Find inventory value using depreciation calculators
 Date: 6/15/2026*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioP4
{
    internal class DepreciationDoubleDeclining : DepreciationStraightLine
    {
        // find total depreciation
        public override void Calc()
        {
            AnnualDepreciation = StartValue - EndValue;
        }

        public override string ToString()
        {
            return base.ToString() + " using double declining method.";
        }
    }
}
