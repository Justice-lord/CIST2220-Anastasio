/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Sprocket Order App
Date : 6/21/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AnastasioP5
{
    /// <summary>
    /// Represents a mailing address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or Sets City portion
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State portion
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Steet portion
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode portion
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Initializes a new Address object with default values
        /// </summary>
        public Address() : this ("TBD", "TBD", "TBD", "TBD")
        {
        }

        /// <summary>
        /// Initializes a new Address object with given values
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="street">The street address.</param>
        /// <param name="zipCode">the ZIP code.</param>
        public Address(string city, string state, string street, string zipCode)
        {
            this.City = city;
            this.State = state;
            this.Street = street;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// Returns Address as a formatted string
        /// </summary>
        /// <returns>A formatted address string</returns>
        public override string ToString()
        {
            return $"{Street}, {City}, {State}, {ZipCode}";
        }
    }
}
