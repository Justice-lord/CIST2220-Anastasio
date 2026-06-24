using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class PhoneBook
    {
        public List<IPhoneBookItem> PhoneBookEntries { get; set; }

        public PhoneBook()
        {
            PhoneBookEntries = new List<IPhoneBookItem>();
        }

        public string GetPhoneBook()
        {
            string phoneBook = "";
            foreach (var item in PhoneBookEntries)
            {
                phoneBook += item.GetContactSummary() + "\n\n";
            }
            return phoneBook;
        }
    }
}
