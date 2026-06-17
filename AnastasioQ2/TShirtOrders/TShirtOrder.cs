using System;
//TShirtOrder.cs
//Programmer: Rob Garner (rgarner7@cnm.edu)
//Date: 10 Mar 2020
//Purpose: Model a TShirt order.
namespace TShirtOrders
{
    /// <summary>
    /// TShirtOrder
    /// Provides a model of a shirt order.
    /// </summary>
    public class TShirtOrder
    {
        // TA moved required param to front made it optional
        public TShirtOrder(double printAreaInSqIn = 0, string firstName="",string lastName = "", string address = "", DateTime? orderDate=null,bool isLocalPickup=true,  int numColors=1,int numShirts=1)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            IsLocalPickup = isLocalPickup;
            this.printAreaInSqIn = printAreaInSqIn;
            this.numColors = numColors;
            this.numShirts = numShirts;
            Calc();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsLocalPickup { get; set; }
        private double printAreaInSqIn;
        public double PrintAreaInSqIn
        {
            get { return printAreaInSqIn; }
            set { printAreaInSqIn = value; Calc(); }
        }

        private int numColors;
        public int NumColors
        {
            // TA fixed to use fields
            get { return numColors; }
            set { numColors = value; Calc(); }
        }

        private int numShirts;
        public int NumShirts
        {
            get { return numShirts; }
            set { numShirts = value; Calc(); }
        }
        // TA switched to private set instead of get
        public decimal Price { get; private set; }
        private void Calc()
        {
            // TA fixed type mismatch
            Price = NumShirts * ((decimal)NumColors * 2.25m + (decimal)PrintAreaInSqIn * .05m);
        }
        public override string ToString()
        {
            return FirstName+" "
                +LastName+" "
                // TA checking for nullable
                +OrderDate?.ToString("MM/dd/yyyy HH:mm:ss")+" "
                +" Price: "+Price.ToString("c");
        }
    }
}
