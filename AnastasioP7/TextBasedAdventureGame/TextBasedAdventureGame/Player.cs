using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class Player
    {
        private int inventorySize;

        public List<IPortable> Inventory {  get; set; }
        public MapLocation Location { get; set; }
        public int MaxInventory {  get; set; }

        public Player(MapLocation location)
        {
            this.Location = location;
            Inventory = new List<IPortable>();
            MaxInventory = 9;
        }

        public bool AddInventoryItem(IPortable item)
        {
            if (inventorySize + item.Size > MaxInventory)
            {
                return false;
            }

            Inventory.Add(item);
            inventorySize += item.Size;
            return true;
        }

        public bool RemoveInventoryItem(IPortable item)
        {
            if (Inventory.Remove(item))
            {
                inventorySize -= item.Size;
                return true;
            }

            return false;
        }
    }
}
