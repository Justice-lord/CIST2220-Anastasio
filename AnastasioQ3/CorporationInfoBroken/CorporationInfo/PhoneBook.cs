using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
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
            string phonebook = "";
            // TA changed string to IPhoneBookItem so we can foreach through the list
            foreach (IPhoneBookItem item in PhoneBookEntries)
            {
                phonebook += item.GetContactSummary() + "\n\n";
            }
            return phonebook;
        }

    }
}
