/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Sprocket Order App
Date : 6/21/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shell;

namespace AnastasioP5
{
    public class PlasticSprocket : Sprocket
    {
        public PlasticSprocket()
        {
        }

        public PlasticSprocket(int itemId, int numItem, int numTeeth) : base(itemId, numItem, numTeeth)
        {
        }

        protected override void Calc()
        {
            Price = (NumTeeth * NumItem) * 0.02m;
        }

        protected override string GetMaterial() => "Plastic";

        public override string ToString()
        {
            return base.ToString();
        }
    }
}