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
    /// Contract to enforce do and undo functionality for children
    /// </summary>
    interface IInventoryCommand
    {
        void Do();
        void Undo();
    }
}
