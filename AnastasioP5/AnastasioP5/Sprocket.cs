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
    public abstract class Sprocket
    {
        private int numItem;
        private int numTeeth;
        private decimal price;
        private int itemID;

        public int NumItem { get; set; }
        public int NumTeeth { get; set; }

        public decimal Price { get; protected set; }

        public int ItemID { get; }

        public Sprocket() : this(-1, -1, -1)
        {
        }

        public Sprocket(int itemID, int numItem, int numTeeth)
        {
            this.ItemID = itemID;
            this.NumItem = numItem;
            this.NumTeeth = numTeeth;
            Calc();
        }
        protected abstract void Calc();
        protected abstract string GetMaterial();

        public override string ToString()
        {
            return $"Order#: {ItemID}, Material: {GetMaterial()}, Amount: {NumItem}, # of Teeth: {NumTeeth}, Price: {Price}";
        }
    }
}
