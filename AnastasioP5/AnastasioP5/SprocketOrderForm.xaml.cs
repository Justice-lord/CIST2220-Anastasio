/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 Purpose: Sprocket Order App
Date : 6/21/2026*/

using Microsoft.Win32;
using System.IO;
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

namespace AnastasioP5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SprocketOrderForm : Window
    {
        public SprocketOrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open Sprocket Form dialog and add item to Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SprocketFrom();

            dialog.Owner = this;

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                lbxorders.Items.Add(dialog.NewSprocket);
            }

        }

        /// <summary>
        /// Open a confirm dialog and delete item from Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbxorders.SelectedItem != null)
            {
                var result = MessageBox.Show("Are you sure you want to remove this item?", "Confirm Removal", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    lbxorders.Items.Remove(lbxorders.SelectedItem);
                }
            }
        }

        /// <summary>
        /// Open a file dialog to save a formatted block of text to a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Address addr = new Address();

            if (chxLocalPickup.IsChecked == true)
            {
                addr = null;
            }
            else if (chxLocalPickup.IsChecked == false)
            {
                addr.City =tbxCity.Text;
                addr.Street =tbxStreet.Text;
                addr.State =tbxState.Text;
                addr.ZipCode =tbxZipCode.Text;
            }

            SprocketOrder order = new SprocketOrder(lbxorders.Items.Cast<Sprocket>().ToList(),tbxName.Text, addr);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt) | *.txt";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(order.ToString());
                    writer.WriteLine();
                    writer.WriteLine();
                    foreach (Sprocket item in lbxorders.Items)
                    {
                        writer.WriteLine(item.ToString());
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("File save successfully", "Save Complete", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        /// <summary>
        /// Collapse the Address section of form if local pickup is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chxLocalPickup_Click(object sender, RoutedEventArgs e)
        {
            if (chxLocalPickup.IsChecked == true)
            {
                grdAddress.Visibility = Visibility.Collapsed;
            }
            else if (chxLocalPickup.IsChecked == false)
            {
                grdAddress.Visibility= Visibility.Visible;
            }
        }
    }
}