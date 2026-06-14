using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomExceptionsDemo
{
    internal class SocialSecurityNumber
    {
        private string ssn;

        public string SSN
        {
            get { return ssn; }
            set
            {
                string pattern = @"^\d{3}-\d{2}-\d{4}$";

                if (Regex.IsMatch(value, pattern))
                {
                    ssn = value;
                }
                else
                {
                    throw new SSNFormatException();
                }
            }
        }
    }
}
