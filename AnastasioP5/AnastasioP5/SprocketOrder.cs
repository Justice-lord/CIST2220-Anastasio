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
    /// Represents a whole customer order
    /// </summary>
    public class SprocketOrder
    {
        /// <summary>
        /// Get or Set a List of sprocket objects
        /// </summary>
        public List<Sprocket> Items { get; set; }

        /// <summary>
        /// Get or Set a Address object
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Get or Set Customer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get to Set Customer order price
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Init a Sprocket Order object with default values
        /// </summary>
        public SprocketOrder() : this(new List<Sprocket>(), "TBD", null, 0m)
        {
        }

        /// <summary>
        /// Init a Sprocket Order object with given values
        /// </summary>
        /// <param name="items">The list of Sprockets</param>
        /// <param name="name">The customer name</param>
        /// <param name="address">The address entered</param>
        /// <param name="totalPrice">The total price of the sprockets</param>
        public SprocketOrder(List<Sprocket> items, string name, Address address , decimal totalPrice = 0m)
        {
            this.Name = name;
            this.Address = address;
            this.TotalPrice = totalPrice;
            this.Items = items;
            Calc();
        }
        
        /// <summary>
        /// Calculate the total price of the Listbox orders
        /// </summary>
        private void Calc()
        {
            TotalPrice = 0;

            foreach (Sprocket item in Items)
            {
                TotalPrice += item.Price;
            }
        }
        
        /// <summary>
        /// Returns a formatted string representing the Sprocket Order
        /// </summary>
        /// <returns>returns a formatted string</returns>
        public override string ToString()
        {
            string addressText = (Address == null)
                ? "Local Pickup"
                : Address.ToString();

            return $"Name: {Name}, # of Items: {Items.Count}, Price: {TotalPrice}, Address: {addressText}";
        }
    }
}
