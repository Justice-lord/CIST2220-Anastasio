/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Demonstrate interfaces using Command pattern design
Date: 6/26/2026*/

using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioP6
{
    /// <summary>
    /// Represents Command to Add one Item to List
    /// </summary>
    class AddOneCommand : IInventoryCommand
    {
        /// <summary>
        /// Get or Set Item object
        /// </summary>
        public InventoryItem Item { get; set; }

        /// <summary>
        /// Get or Set List of Item objects
        /// </summary>
        public List<InventoryItem> TargetList { get; set; }

        /// <summary>
        /// Init Command using values provided
        /// </summary>
        /// <param name="item">Object Item</param>
        /// <param name="targetList">List of Item objects</param>
        public AddOneCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item;
            TargetList = targetList;
        }

        /// <summary>
        /// Add one Item to List
        /// </summary>
        public void Do()
        {
            TargetList.Add(Item);
        }

        /// <summary>
        /// Remove one Item from List
        /// </summary>
        public void Undo()
        {
            TargetList.Remove(Item);
        }
    }
}
