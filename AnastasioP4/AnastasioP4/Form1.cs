/*Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 * Purpose : Find inventory value using depreciation calculators
 Date: 6/15/2026*/

using System.Numerics;
using System.Windows.Forms;

namespace AnastasioP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // list to contain all objects
        List<DepreciationStraightLine> invList = new List<DepreciationStraightLine>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxError.Visible = false;
            try
            {
                // determine which class to use
                if (rbnSingleLine.Checked)
                {
                    DepreciationStraightLine straightLine = new DepreciationStraightLine();
                    straightLine.Title = tbxTitle.Text;
                    straightLine.StartValue = decimal.Parse(tbxStartValue.Text);
                    straightLine.EndValue = decimal.Parse(tbxEndValue.Text);
                    straightLine.Lifetime = int.Parse(tbxLifetime.Text);
                    straightLine.ItemIn = dtpDateIn.Value;
                    straightLine.ItemOut = dtpDateOut.Value;

                    invList.Add(straightLine);
                }
                else if (rbnDoubleDeclining.Checked)
                {
                    DepreciationDoubleDeclining doubleDeclining = new DepreciationDoubleDeclining();
                    doubleDeclining.Title = tbxTitle.Text;
                    doubleDeclining.StartValue = decimal.Parse(tbxStartValue.Text);
                    doubleDeclining.EndValue = decimal.Parse(tbxEndValue.Text);
                    doubleDeclining.Lifetime = int.Parse(tbxLifetime.Text);
                    doubleDeclining.ItemIn = dtpDateIn.Value;
                    doubleDeclining.ItemOut = dtpDateOut.Value;

                    invList.Add(doubleDeclining);
                }

                // refresh lbxInventory
                lbxInventory.DataSource = null;
                lbxInventory.DataSource = invList;
            
            }
            catch (System.NullReferenceException ex)
            {
                tbxError.Text = "No values set for inventory object.";
                tbxError.Visible = true;
            }
            catch (Exception ex)
            {
                tbxError.Text = $"Error! {ex.GetType} {ex.Message}";
                tbxError.Visible = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tbxError.Visible=false;

            try
            {
                // remove selected item
                if (lbxInventory.SelectedItem is DepreciationStraightLine obj)
                {
                    invList.Remove(obj);

                    lbxInventory.DataSource = null;
                    lbxInventory.DataSource = invList;
                }
            } catch (Exception ex)
            {
                tbxError.Text = $"Error! {ex.GetType} {ex.Message}";
                tbxError.Visible = true;
            }
        }

        private void lbxInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // populate gui with object fields
            DepreciationStraightLine viewObj = (DepreciationStraightLine)lbxInventory.SelectedItem;
            tbxTitle.Text = viewObj.Title;
            tbxStartValue.Text = viewObj.StartValue.ToString();
            tbxEndValue.Text = viewObj.EndValue.ToString();
            tbxLifetime.Text = viewObj.Lifetime.ToString();
            dtpDateIn.Value = viewObj.ItemIn;
            dtpDateOut.Value = viewObj.ItemOut;

            if (viewObj is DepreciationStraightLine)
            {
                rbnSingleLine.Checked = true;
            }
            else if (viewObj is DepreciationDoubleDeclining)
            {
                rbnDoubleDeclining.Checked = true;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // show results
            decimal total = invList.Sum(x => x.AnnualDepreciation);

            tbxSummary.Text = $"The Total value in your inventory is ${total}";
            tbxSummary.Visible = true;
        }
    }
}
