/*Programmer: Tucker Anastasio (tananstasio@student.cnm.edu)
 *Purpose: Calculate the price of logo with diffrent options
  Date: 6/14/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3LogoStore
{
    internal class LogoOrderItem
    {
        // private fields
        private bool hasLogo;
        private string itemType;
        private int numOfColors;
        private int numOfItems;
        private string textOnItem;

        // class properties
        public bool HasLogo
        {
            get { return hasLogo; }
            set
            {
                hasLogo = value;
                Calc();
            }
        }
        public int ItemID { get; set; }
        public string ItemType
        {
            get { return itemType; }
            set
            {
                itemType = value;
                Calc();
            }
        }
        public int NumOfColors
        {
            get { return  numOfColors; }
            set
            {
                numOfColors = value;
                Calc();
            }
        }
        public int NumOfItems
        {
            get { return numOfItems; }
            set
            {
                numOfItems = value;
                Calc();
            }
        }

        public string TextOnItem
        {
            get { return  textOnItem; }
            set
            {
                textOnItem = value;
                Calc();
            }
        }

        public decimal Price { get; private set; }

        // Constuctors
        public LogoOrderItem(bool hasLogo, string itemType, int numOfColor, int numOfItems, string textOnItem, int itemID)
        {
            this.HasLogo = hasLogo;
            this.ItemType = itemType;
            this.NumOfColors = numOfColor;
            this.NumOfItems = numOfItems;
            this.TextOnItem = textOnItem;
            this.ItemID = itemID;
        }

        public LogoOrderItem(bool hasLogo, string textOnItem)
            : this (hasLogo, "mug", 0, 0, textOnItem, -1)
        {
        }

        public LogoOrderItem()
            : this (false, "mug", 0, 0, "none", -1)
        {
        }

        // clac price
        private void Calc()
        {
            decimal itemPrice = 0m;

            if (string.IsNullOrEmpty(ItemType))
                return;

            switch (ItemType.ToLower())
            {
                case "pen":
                    itemPrice = 1.00m;
                    break;
                case "mug":
                    itemPrice = 3.50m;
                    break;
                case "usb":
                    itemPrice = 4.00m;
                    break;
            }

            if (HasLogo)
            {
                itemPrice += 0.10m;
            }
            else
            {
                itemPrice += 0.05m;
            }

            itemPrice += numOfColors * 0.03m;

            if (!string.IsNullOrEmpty(TextOnItem))
            {
                itemPrice += 0.05m;
            }

            Price = itemPrice * numOfItems;
        }

        // return results
        public string GetOrderSummary()
        {
            return $"Order {ItemID}: {NumOfItems} {ItemType} with {NumOfColors} color logo with the following text: {TextOnItem} Price: {Price}";
        }
    }
}
