/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Demonstrate interfaces using Command pattern design
Date: 6/26/2026*/

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnastasioP6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Lists for storing Inventory Items and Commands
        /// </summary>
        List<InventoryItem> inventoryItems = new List<InventoryItem>();
        List<IInventoryCommand> commands = new List<IInventoryCommand>();
        public MainWindow()
        {
            InitializeComponent();

            // link Inventory Items to List Box
            lbxInventoryList.ItemsSource = inventoryItems;
        }

        /// <summary>
        /// Add Item to List Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOne_Click(object sender, RoutedEventArgs e)
        {
            InventoryItem item = new InventoryItem(tbxItemName.Text);
            AddOneCommand command = new AddOneCommand(item, inventoryItems);
            command.Do();
            commands.Add(command);
            lbxInventoryList.Items.Refresh();
        }

        /// <summary>
        /// Add a random number of Item to List Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMulti_Click(object sender, RoutedEventArgs e)
        {
            InventoryItem item = new InventoryItem(tbxItemName.Text);
            AddMultipleCommand command = new AddMultipleCommand(item, inventoryItems);
            command.Do();
            commands.Add(command);
            lbxInventoryList.Items.Refresh();
        }

        /// <summary>
        /// Undo the last command that ran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (commands.Count > 0)
            {
                IInventoryCommand lastCommand = commands[commands.Count - 1];

                lastCommand.Undo();

                lbxInventoryList.Items.Refresh();

                commands.RemoveAt(commands.Count - 1);
            }
        }
    }
}