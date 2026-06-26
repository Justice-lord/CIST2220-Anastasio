/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Demonstrate interfaces using Command pattern design
Date: 6/26/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioP6
{
    /// <summary>
    /// Represent Adding a random number of Item to List Box
    /// </summary>
    class AddMultipleCommand : IInventoryCommand
    {
        // field for random number
        private int number;

        /// <summary>
        /// Set or Get Item object
        /// </summary>
        public InventoryItem Item { get; set; }

        /// <summary>
        /// Set or Get List of Items
        /// </summary>
        public List<InventoryItem> TargetList { get; set; }

        /// <summary>
        /// Init Command object using provided values
        /// </summary>
        /// <param name="item">Object Item</param>
        /// <param name="targetList">List of Items</param>
        public AddMultipleCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item;
            TargetList = targetList;
        }

        /// <summary>
        /// Add a random amount between 1 -6 of Item to List
        /// </summary>
        public void Do()
        {
            Random random = new Random();

            number = random.Next(1,7);

            for (int i = 0; i < number; i++)
            {
                TargetList.Add(Item);
            }
        }

        /// <summary>
        /// Remove amount of Items equal to those added
        /// </summary>
        public void Undo()
        {
            for (int i = 0;i < number;i++)
            {
                TargetList.Remove(Item);
            }
        }
    }
}
