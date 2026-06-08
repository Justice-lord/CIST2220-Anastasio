using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioQ1
{
    internal class GravitationalForce
    {
        // fields
        private double gravConstant = 6.67408e-11;
        private double mass1;
        private double mass2;
        private double distance = 1;

        // default constructor
        public GravitationalForce()
        {

        }

        // properties
        public string Name1 {get; set;}
        public string Name2 {get; set;}
        public double GravForce { get; private set;}

        public double Mass1
        {
            get { return mass1; }
            set
            {
                mass1 = value;
                Calc();
            }
        }

        public double Mass2
        {
            get { return mass2; }
            set
            {
                mass2 = value;
                Calc();
            }
        }

        public double Distance
        {
            get { return distance; }
            set
            {
                distance = value;
                Calc();
            }
        }

        // force calculation
        private void Calc()
        {
            GravForce = gravConstant * ((Mass1 * Mass2) / Math.Pow(Distance, 2));
        }

        // display results
        public override string ToString()
        {
            return $"\nThe Force between {Name1} and {Name2} is {GravForce:E} newtons.";
        }
    }
}
