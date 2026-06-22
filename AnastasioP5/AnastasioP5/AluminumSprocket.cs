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
    /// <summary>
    /// Represents an Aluminum Sprocket
    /// </summary>
    public class AluminumSprocket : Sprocket
    {
        /// <summary>
        /// Init a new Aluminum sprocket with default values
        /// </summary>
        public AluminumSprocket()
        {
        }

        /// <summary>
        /// Init anew Aluminum sprocket with given values
        /// </summary>
        /// <param name="itemId">The itemid.</param>
        /// <param name="numItem">The number of items</param>
        /// <param name="numTeeth">The number of teeth</param>
        public AluminumSprocket(int itemId, int numItem, int numTeeth) : base(itemId, numItem, numTeeth)
        {
        }

        /// <summary>
        /// Calculates the cost of the Aluminum sprockets order
        /// </summary>
        protected override void Calc()
        {
            Price = (NumTeeth * NumItem) * 0.04m;
        }

        /// <summary>
        /// Provides the material for parent ToString()
        /// </summary>
        /// <returns>returns the sprocket material</returns>
        protected override string GetMaterial() => "Aluminum";

        /// <summary>
        /// Use parent ToString() to return a formatted string
        /// </summary>
        /// <returns>returns parent ToString()</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
