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
using System.Windows.Shapes;

namespace AnastasioP5
{
    /// <summary>
    /// Interaction logic for SprocketFrom.xaml
    /// </summary>
    public partial class SprocketFrom : Window
    {
        public Sprocket NewSprocket { get; private set; }
        public SprocketFrom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int id =int.Parse(tbxItemID.Text);
            int teeth = int.Parse(tbxNumTeeth.Text);
            int items = int.Parse(tbxNumItems.Text);

            string material = ((ComboBoxItem)cbxItemType.SelectedItem).Content.ToString();

            Sprocket sprocket;

            switch (material)
            {
                case "Steel":
                    sprocket = new SteelSprocket(id, items, teeth);
                    break;
                case "Aluminum":
                    sprocket = new AluminumSprocket(id, items, teeth);
                    break;
                default: 
                    sprocket = new PlasticSprocket(id, items, teeth);
                    break;
            }

            NewSprocket = sprocket;
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
