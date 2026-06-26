/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Demonstrate interfaces using Command pattern design
Date: 6/26/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioP6
{
    /// <summary>
    /// Represents an Item to be added to List Box
    /// </summary>
    class InventoryItem
    {
        /// <summary>
        /// Set or Get Item Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initialize Item object
        /// </summary>
        /// <param name="name">Name of Item</param>
        public InventoryItem(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Return Item Name in string form
        /// </summary>
        /// <returns>string Item Name</returns>
        public override string ToString()
        {
            return $"Item: {Name}";
        }
    }
}
