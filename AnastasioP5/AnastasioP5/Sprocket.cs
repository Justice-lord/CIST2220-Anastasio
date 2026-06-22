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
    /// Represent the Parent class for all sprockets
    /// </summary>
    public abstract class Sprocket
    {
        /// <summary>
        /// Get or Set Number of Items
        /// </summary>
        public int NumItem { get; set; }

        /// <summary>
        /// Get or Set Number of teeth
        /// </summary>
        public int NumTeeth { get; set; }

        /// <summary>
        /// Get the price of the sprocket
        /// </summary>
        public decimal Price { get; protected set; }

        /// <summary>
        /// Get the ItemID
        /// </summary>
        public int ItemID { get; }

        /// <summary>
        /// Init a new Sprocket object with default values
        /// </summary>
        public Sprocket() : this(-1, -1, -1)
        {
        }

        /// <summary>
        /// Init a new Sprocket object with given values
        /// </summary>
        /// <param name="itemID">The ItemID.</param>
        /// <param name="numItem">The number of items</param>
        /// <param name="numTeeth">The number of teeth</param>
        public Sprocket(int itemID, int numItem, int numTeeth)
        {
            this.ItemID = itemID;
            this.NumItem = numItem;
            this.NumTeeth = numTeeth;
            Calc();
        }

        /// <summary>
        /// Require child classes to have a Calc() function
        /// </summary>
        protected abstract void Calc();

        /// <summary>
        /// Require child classes to have GetMaterial() function
        /// </summary>
        /// <returns>will return the type of material</returns>
        protected abstract string GetMaterial();

        /// <summary>
        /// Returns a formatted string representing the Sprocket
        /// </summary>
        /// <returns>returns a formatted string</returns>
        public override string ToString()
        {
            return $"Order#: {ItemID}, Material: {GetMaterial()}, Amount: {NumItem}, # of Teeth: {NumTeeth}, Price: {Price}";
        }
    }
}
