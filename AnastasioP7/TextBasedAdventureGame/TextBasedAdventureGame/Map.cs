// TravelOption
// Programer: Rob Garner (rgarner7@cnm.edu)
// Date: 25 May 2016
// Represents a travel option.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TextBasedAdventureGame
{
    /// <summary>
    /// Class that represents the game. 
    /// Has a map and location of player.
    /// </summary>
    class Map
    {
        /// <summary>
        /// List of map locations.
        /// </summary>
        public List<MapLocation> Locations { get; set; }

        public Player Player { get; set; }

        /// <summary>
        /// Constructor that creates the game map.
        /// </summary>
        public Map()
        {
            //Create map locations first
            Locations = new List<MapLocation>();   
            
            //Add locations to the locations list
            Locations.Add(new MapLocation("You are standing in the center of a quiet town. There is a war torn well that stands in the middle of the town square."));
            Locations.Add(new MapLocation("Before you stands a dilapidated watch tower flanked on either side by wooden walls."));
            Locations.Add(new MapLocation("You walk down a small path, coming to the collapsed entrance of an abandoned gold mine."));
            Locations.Add(new MapLocation("You come to a dense forest, you can barely see ten feet into the forest."));
            Locations.Add(new MapLocation("You walk down a well worn road, at the end stands a partial burnt blacksmiths shop"));

            //Now add travel options to each map location

            //Town Square
            Locations[0].TravelOptions.Add(new TravelOption("A large tower sits to the north.",Locations[1]));
            Locations[0].TravelOptions.Add(new TravelOption("A stone path leads south down a hill.",Locations[2]));
            Locations[0].TravelOptions.Add(new TravelOption("A forest lies to the east.",Locations[3]));
            Locations[0].TravelOptions.Add(new TravelOption("A building is at the end of a road to the west.",Locations[4]));

            Locations[0].Items.Add(new InventoryItem("Pile of coins", 3));
            HidingPlace bucket = new HidingPlace("Turned over bucket");
            bucket.HiddenObject = new InventoryItem("Pommel", 1);
            Locations[0].Items.Add(bucket);

            //Watch Tower
            Locations[1].TravelOptions.Add(new TravelOption("The gravel path leading back to the square is behind you.", Locations[0]));

            Locations[1].Items.Add(new InventoryItem("Large Blade", 4));

            //Abandoned Mine
            Locations[2].TravelOptions.Add(new TravelOption("A hill stretches up behind you.", Locations[0]));

            Locations[2].Items.Add(new PortableHidingPlace("Satchel", 4, new InventoryItem("Hilt", 3)));
            Locations[2].Items.Add(new InventoryItem("Lantern", 3));

            //Forest Path
            Locations[3].TravelOptions.Add(new TravelOption("Behind you sits the town square.", Locations[0]));

            Locations[3].Items.Add(new InventoryItem("Axe", 5));
            HidingPlace rock = new HidingPlace("A poor quality fake rock");
            rock.HiddenObject = new InventoryItem("Brass Key", 1);
            Locations[3].Items.Add(rock);

            //Blacksmith
            Locations[4].TravelOptions.Add(new TravelOption("The road behind you leads back to the town square", Locations[0]));
            Locations[4].Items.Add(new InventoryItem("Anvil", 25));

            Player = new Player(Locations[0]);
        }

    }
}
