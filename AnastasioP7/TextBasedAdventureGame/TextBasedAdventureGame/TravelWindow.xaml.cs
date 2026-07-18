// TravelWindow
// Programer: Rob Garner (rgarner7@cnm.edu)
// Date: 25 May 2016
// User interface that provides user capability to travel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBasedAdventureGame
{
    /// <summary>
    /// Window that shows player where they are and provides capability to move from location to location in the map.
    /// </summary>
    public partial class TravelWindow : Window
    {
        /// <summary>
        /// Game object that has map
        /// </summary>
        Map game;

        /// <summary>
        /// Initialize the form, the game and call display location to start the form.
        /// </summary>
        public TravelWindow()
        {
            InitializeComponent();
            game = new Map();
            DisplayLocation();
        }

        /// <summary>
        /// Tells the player where they are.
        /// </summary>
        private void DisplayLocation()
        {
            tbxDescription.Text = game.Player.Location.Description;
            lbxLocationItems.ItemsSource = game.Player.Location.Items;
            lbxInventory.ItemsSource = game.Player.Inventory;
            lbxTravelOptions.ItemsSource = game.Player.Location.TravelOptions;

            UpdateButtons();
        }

        /// <summary>
        /// Double click a travel option to move to a new location on the map.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxTravelOptions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TravelOption to = (TravelOption)lbxTravelOptions.SelectedItem;
            game.Player.Location = to.Location;
            DisplayLocation();
            UpdateButtons();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            GameObject selectedItem = (GameObject)lbxLocationItems.SelectedItem;

            if (selectedItem == null)
            {
                AddStatusMessage("Select Something to search.");
                return;
            }

            if (selectedItem is IHidingPlace hidingPlace)
            {
                GameObject found = hidingPlace.Search();

                if (found != null)
                {
                    game.Player.Location.Items.Add(found);
                    AddStatusMessage($"You found: {found.Description}");
                }
                else
                {
                    AddStatusMessage("There is nothing to find.");
                }
            }
            else
            {
                AddStatusMessage("You cannot search that.");
            }

            lbxLocationItems.Items.Refresh();
            DisplayLocation();
        }
        private void btnTake_Click(object sender, RoutedEventArgs e)
        {
            GameObject selectedItem = (GameObject) lbxLocationItems.SelectedItem;
            if (selectedItem == null)
            {
                AddStatusMessage("Select something to take.");
                return;
            }

            if (selectedItem is IPortable portableItem)
            {
                if (game.Player.AddInventoryItem(portableItem))
                {
                    game.Player.Location.Items.Remove(selectedItem);
                    AddStatusMessage($"You Picked up: {selectedItem.Description}");
                }
                else
                {
                    AddStatusMessage("Your inventory is full.");
                }
            }
            else
            {
                AddStatusMessage("You cannot take that.");
            }

            lbxLocationItems.Items.Refresh();
            lbxInventory.Items.Refresh();
            DisplayLocation();
        }
        private void btnDrop_Click(object sender, RoutedEventArgs e)
        {
            IPortable selectedItem = (IPortable)lbxInventory.SelectedItem;

            if (selectedItem == null)
            {
                AddStatusMessage("select something to drop.");
                return;
            }

            if (game.Player.RemoveInventoryItem(selectedItem))
            {
                game.Player.Location.Items.Add((GameObject)selectedItem);

                AddStatusMessage($"You dropped: {((GameObject)selectedItem).Description}");
            }

            lbxLocationItems.Items.Refresh();
            lbxInventory.Items.Refresh();
            DisplayLocation();
        }

        private void btnForge_Click(object sender, RoutedEventArgs e)
        {
            IPortable blade = FindInventoryItem("Large Blade");
            IPortable hilt = FindInventoryItem("Hilt");
            IPortable pommel = FindInventoryItem("Pommel");

            game.Player.Inventory.Remove(blade);
            game.Player.Inventory.Remove(hilt);
            game.Player.Inventory.Remove(pommel);

            InventoryItem sword = new InventoryItem("Sword", 5);

            game.Player.Inventory.Add(sword);

            lbxGameStatus.Items.Clear();

            AddStatusMessage("You forged the sword YOU WIN!!!!");

            lbxInventory.Items.Refresh();
            DisplayLocation();
        }

        private void UpdateButtons()
        {
            bool showForgeButton =
                game.Player.Location == game.Locations[4] &&
                HasItem("Large Blade") &&
                HasItem("Hilt") &&
                HasItem("Pommel");

            btnForge.Visibility = showForgeButton
                ? Visibility.Visible 
                : Visibility.Collapsed;
        }

        private bool HasItem(string description)
        {
            return game.Player.Inventory
                .OfType<GameObject>()
                .Any(item => item.Description == description);
        }

        private IPortable FindInventoryItem(string description)
        {
            return game.Player.Inventory
                .FirstOrDefault(item => ((GameObject) item).Description == description);
        }

        private void AddStatusMessage(string message)
        {
            lbxGameStatus.Items.Add(message);

            if (lbxGameStatus.Items.Count > 10)
            {
                lbxGameStatus.Items.RemoveAt(0);
            }
        }
    }
}
