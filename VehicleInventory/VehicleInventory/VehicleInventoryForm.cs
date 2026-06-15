namespace VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = tbxLicense.Text;
                sedan.VIN = tbxVIN.Text;
                vehicles.Add(sedan);

                lbxInventory.DataSource = null;
                lbxInventory.DataSource = vehicles;
                rtbResults.Text = "Successfully added sedan";
            }
            else if (cbxType.Text == "Truck")
            {
                Truck truck = new Truck(tbxVIN.Text, tbxLicense.Text);
                vehicles.Add(truck);

                lbxInventory.DataSource = null;
                lbxInventory.DataSource = vehicles;
                rtbResults.Text = "Successfully added Truck";
            }
        }

        private void lbxInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)lbxInventory.SelectedItem;
            rtbSummary.Text = vehicle.GetDescription();
        }
    }
}
