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
    class SprocketOrder
    {
        public List<Sprocket> Items { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }

        public SprocketOrder() : this(new List<Sprocket>(), "TBD", null, 0m)
        {
        }

        public SprocketOrder(List<Sprocket> items, string name, Address address , decimal totalPrice = 0m)
        {
            this.Name = name;
            this.Address = address;
            this.TotalPrice = totalPrice;
            this.Items = items;
            Calc();
        }

        public void Add(Sprocket item) { Items.Add(item); Calc(); }

        public void Remove(Sprocket item) { Items.Remove(item); Calc(); }

        private void Calc()
        {
            TotalPrice = 0;

            foreach (Sprocket item in Items)
            {
                TotalPrice += item.Price;
            }
        }

        public override string ToString()
        {
            string addressText = (Address == null)
                ? "Local Pickup"
                : Address.ToString();

            return $"Name: {Name}, # of Items: {Items.Count}, Price: {TotalPrice}, Address: {addressText}";
        }
    }
}
