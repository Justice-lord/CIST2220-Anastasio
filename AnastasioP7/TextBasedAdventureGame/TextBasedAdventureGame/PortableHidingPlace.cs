using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class PortableHidingPlace : GameObject, IPortable, IHidingPlace
    {
        private GameObject item;

        public GameObject HiddenObject {  get; set; }

        public int Size { get; set; }

        public PortableHidingPlace(string description, int size, GameObject item) : base(description)
        {
            this.Size = size;
            this.HiddenObject = item;
        }

        public GameObject Search()
        {
            item = HiddenObject;
            HiddenObject = null;
            return item;
        }
    }
}
