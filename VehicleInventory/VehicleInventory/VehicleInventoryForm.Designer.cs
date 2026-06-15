namespace VehicleInventory
{
    partial class VehicleInventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabNewVehicle = new TabPage();
            btnAdd = new Button();
            rtbResults = new RichTextBox();
            cbxType = new ComboBox();
            tbxVIN = new TextBox();
            tbxLicense = new TextBox();
            lblType = new Label();
            lblVIN = new Label();
            lblLicense = new Label();
            lblNewTitle = new Label();
            tabInventoryList = new TabPage();
            rtbSummary = new RichTextBox();
            lbxInventory = new ListBox();
            tabControl1.SuspendLayout();
            tabNewVehicle.SuspendLayout();
            tabInventoryList.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Right;
            tabControl1.Controls.Add(tabNewVehicle);
            tabControl1.Controls.Add(tabInventoryList);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabNewVehicle
            // 
            tabNewVehicle.Controls.Add(btnAdd);
            tabNewVehicle.Controls.Add(rtbResults);
            tabNewVehicle.Controls.Add(cbxType);
            tabNewVehicle.Controls.Add(tbxVIN);
            tabNewVehicle.Controls.Add(tbxLicense);
            tabNewVehicle.Controls.Add(lblType);
            tabNewVehicle.Controls.Add(lblVIN);
            tabNewVehicle.Controls.Add(lblLicense);
            tabNewVehicle.Controls.Add(lblNewTitle);
            tabNewVehicle.Location = new Point(4, 4);
            tabNewVehicle.Name = "tabNewVehicle";
            tabNewVehicle.Padding = new Padding(3);
            tabNewVehicle.Size = new Size(742, 418);
            tabNewVehicle.TabIndex = 0;
            tabNewVehicle.Text = "New Vehicle";
            tabNewVehicle.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(319, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rtbResults
            // 
            rtbResults.Location = new Point(6, 267);
            rtbResults.Name = "rtbResults";
            rtbResults.ReadOnly = true;
            rtbResults.Size = new Size(730, 145);
            rtbResults.TabIndex = 8;
            rtbResults.Text = "";
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Sedan", "Truck" });
            cbxType.Location = new Point(365, 174);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(151, 28);
            cbxType.TabIndex = 6;
            cbxType.Text = "Sedan";
            // 
            // tbxVIN
            // 
            tbxVIN.Location = new Point(365, 129);
            tbxVIN.Name = "tbxVIN";
            tbxVIN.Size = new Size(125, 27);
            tbxVIN.TabIndex = 5;
            // 
            // tbxLicense
            // 
            tbxLicense.Location = new Point(365, 84);
            tbxLicense.Name = "tbxLicense";
            tbxLicense.Size = new Size(125, 27);
            tbxLicense.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(284, 178);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            // 
            // lblVIN
            // 
            lblVIN.AutoSize = true;
            lblVIN.Location = new Point(288, 132);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(33, 20);
            lblVIN.TabIndex = 2;
            lblVIN.Text = "VIN";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(276, 87);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(57, 20);
            lblLicense.TabIndex = 1;
            lblLicense.Text = "License";
            // 
            // lblNewTitle
            // 
            lblNewTitle.AutoSize = true;
            lblNewTitle.Location = new Point(302, 35);
            lblNewTitle.Name = "lblNewTitle";
            lblNewTitle.Size = new Size(128, 20);
            lblNewTitle.TabIndex = 0;
            lblNewTitle.Text = "New Vehicle Form";
            // 
            // tabInventoryList
            // 
            tabInventoryList.Controls.Add(rtbSummary);
            tabInventoryList.Controls.Add(lbxInventory);
            tabInventoryList.Location = new Point(4, 4);
            tabInventoryList.Name = "tabInventoryList";
            tabInventoryList.Padding = new Padding(3);
            tabInventoryList.Size = new Size(742, 418);
            tabInventoryList.TabIndex = 1;
            tabInventoryList.Text = "Inventory List";
            tabInventoryList.UseVisualStyleBackColor = true;
            // 
            // rtbSummary
            // 
            rtbSummary.Location = new Point(6, 292);
            rtbSummary.Name = "rtbSummary";
            rtbSummary.ReadOnly = true;
            rtbSummary.Size = new Size(730, 120);
            rtbSummary.TabIndex = 1;
            rtbSummary.Text = "";
            // 
            // lbxInventory
            // 
            lbxInventory.FormattingEnabled = true;
            lbxInventory.Location = new Point(6, 6);
            lbxInventory.Name = "lbxInventory";
            lbxInventory.Size = new Size(730, 264);
            lbxInventory.TabIndex = 0;
            lbxInventory.MouseDoubleClick += lbxInventory_MouseDoubleClick;
            // 
            // VehicleInventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "VehicleInventoryForm";
            Text = "VehicleInvetoryForm";
            tabControl1.ResumeLayout(false);
            tabNewVehicle.ResumeLayout(false);
            tabNewVehicle.PerformLayout();
            tabInventoryList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabNewVehicle;
        private TabPage tabInventoryList;
        private TextBox tbxVIN;
        private TextBox tbxLicense;
        private Label lblType;
        private Label lblVIN;
        private Label lblLicense;
        private Label lblNewTitle;
        private Button btnAdd;
        private RichTextBox rtbResults;
        private ComboBox cbxType;
        private RichTextBox rtbSummary;
        private ListBox lbxInventory;
    }
}
