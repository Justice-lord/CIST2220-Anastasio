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
    /// Represents a Plastic sprocket
    /// </summary>
    public class PlasticSprocket : Sprocket
    {
        /// <summary>
        /// Init a new Platic sprocket object with default values
        /// </summary>
        public PlasticSprocket()
        {
        }

        /// <summary>
        /// Init a new Plastic sprocket object with given values
        /// </summary>
        /// <param name="itemId">The ItemID.</param>
        /// <param name="numItem">The number of items</param>
        /// <param name="numTeeth">The number of teeth</param>
        public PlasticSprocket(int itemId, int numItem, int numTeeth) : base(itemId, numItem, numTeeth)
        {
        }

        /// <summary>
        /// Calculates the price of the Plastic sprockets
        /// </summary>
        protected override void Calc()
        {
            Price = (NumTeeth * NumItem) * 0.02m;
        }

        /// <summary>
        /// Returns the material to the parent ToString()
        /// </summary>
        /// <returns>Returns Plastic</returns>
        protected override string GetMaterial() => "Plastic";

        /// <summary>
        /// Returns the parent formatted string ToSting()
        /// </summary>
        /// <returns>return formatted sting</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}