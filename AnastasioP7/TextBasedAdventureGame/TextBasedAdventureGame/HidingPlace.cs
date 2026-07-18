using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class HidingPlace : GameObject, IHidingPlace
    {

        public GameObject HiddenObject { get; set; }

        public HidingPlace(string description) : base(description)
        {
        }

        public GameObject Search()
        {
            GameObject item = HiddenObject;
            HiddenObject = null;
            return item;
        }
    }
}
