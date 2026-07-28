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

namespace Q4Anastasio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EnergyTypeBase[] energyTypes =
{
                new Gasoline(),
                new Ethanol(),
                new Methanol()
            };
        public MainWindow()
        {
            InitializeComponent();

        }

        public void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            if (rbGasoline.IsChecked == true)
            {
                tbxSummary.Text = DisplayInfo(energyTypes[0]);
            }

            if (rbEthanol.IsChecked == true)
            {
                tbxSummary.Text = DisplayInfo(energyTypes[1]);
            }

            if (rbMethanol.IsChecked == true)
            {
                tbxSummary.Text = DisplayInfo(energyTypes[2]);
            }
        }

        public string DisplayInfo(EnergyTypeBase energyType)
        {
            return energyType.GetName() +
                " is a " + energyType.GetEnergyType() +
                ". Its specific energy is " + energyType.GetSpecificEnergy().ToString() + " MJ/kg." +
                " Its energy density is " + energyType.GetEnergyDensity().ToString() + " MMJ/L.";
        }
    }
}