using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AnastasioP5
{
    public class Address
    {
        private string city;
        private string state;
        private string street;
        private string zipCode;

        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public Address() : this ("TBD", "TBD", "TBD", "TBD")
        {
        }

        public Address(string city, string state, string street, string zipCode)
        {
            this.City = city;
            this.State = state;
            this.Street = street;
            this.ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {State}, {ZipCode}";
        }
    }
}
