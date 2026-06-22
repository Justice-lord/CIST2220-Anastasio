/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Sprocket Order App
Date : 6/21/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioP5
{
    /// <summary>
    /// Represents a Aluminum sprocket
    /// </summary>
    public class SteelSprocket : Sprocket
    {
        /// <summary>
        /// Init a new Steel sprocket object with default values
        /// </summary>
        public SteelSprocket()
        {
        }

        /// <summary>
        /// Init a new Steel sprocket object with given values
        /// </summary>
        /// <param name="itemId">The itemid.</param>
        /// <param name="numItem">The number of items</param>
        /// <param name="numTeeth">The number of teeth</param>
        public SteelSprocket(int itemId, int numItem, int numTeeth) : base(itemId, numItem, numTeeth)
        {
        }

        /// <summary>
        /// Calculate the price of the Steel sprockets
        /// </summary>
        protected override void Calc()
        {
            Price = (NumTeeth * NumItem) * 0.05m;
        }

        /// <summary>
        /// Returns the material to the parent class ToString()
        /// </summary>
        /// <returns>returns Steel to the parent ToString()</returns>
        protected override string GetMaterial() => "Steel";

        /// <summary>
        /// Returns the parent formatted string ToString()
        /// </summary>
        /// <returns>Returns the parent ToString()</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
