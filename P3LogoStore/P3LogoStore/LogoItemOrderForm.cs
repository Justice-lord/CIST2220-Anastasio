/*Programmer: Tucker Anastasio (tananstasio@student.cnm.edu)
 *Purpose: Calculate the price of logo with diffrent options
  Date: 6/14/2026*/

namespace P3LogoStore
{
    public partial class LogoItemOrderForm : Form
    {
        public LogoItemOrderForm()
        {
            InitializeComponent();
        }

        // appear the Number of Colors textbox if logo checked
        private void cbxHasLogo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHasLogo.Checked == true)
            {
                lblNumOfColors.Visible = true;
                tbxNumOfColors.Visible = true;
            }
            else if(cbxHasLogo.Checked == false)
            {
                lblNumOfColors.Visible=false;
                tbxNumOfColors.Visible=false;
            }
        }

        // handle submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasLogo = cbxHasLogo.Checked;
                LogoOrderItem userItem = new LogoOrderItem(hasLogo, tbxTextOnItem.Text);
                userItem.ItemID = int.Parse(tbxOrderNumber.Text);
                userItem.NumOfItems = int.Parse(tbxNumberOfItems.Text);

                if (rbnPen.Checked == true)
                {
                    userItem.ItemType = "pen";
                }
                else if (rbnMug.Checked == true)
                {
                    userItem.ItemType = "mug";
                }
                else if (rbnUSB.Checked == true)
                {
                    userItem.ItemType = "usb";
                }

                if (hasLogo)
                {
                    userItem.NumOfColors = int.Parse(tbxNumOfColors.Text);
                }
                else
                {
                    userItem.NumOfColors = 0;
                }

                tbxResults.Text = userItem.GetOrderSummary();
            } catch (Exception exc)
            {
                tbxResults.Text = $"Error! {exc.GetType()} {exc.Message}";
            }
            
        }

        // handle clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxOrderNumber.Clear();
            tbxNumberOfItems.Clear();
            tbxTextOnItem.Clear();
            tbxNumOfColors.Clear();
            tbxResults.Clear();
            cbxHasLogo.Checked = false;

            foreach (Control control in gbxItemType.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}
