namespace AnastasioP4
{
    partial class Form1
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
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tbxError = new TextBox();
            groupBox1 = new GroupBox();
            rbnDoubleDeclining = new RadioButton();
            rbnSingleLine = new RadioButton();
            dtpDateOut = new DateTimePicker();
            label7 = new Label();
            dtpDateIn = new DateTimePicker();
            label6 = new Label();
            tbxLifetime = new TextBox();
            label5 = new Label();
            tbxEndValue = new TextBox();
            label4 = new Label();
            tbxStartValue = new TextBox();
            label3 = new Label();
            tbxTitle = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            lbxInventory = new ListBox();
            tabPage3 = new TabPage();
            btnSummary = new Button();
            tbxSummary = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "How To Use";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 126);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(378, 70);
            textBox1.TabIndex = 1;
            textBox1.Text = "Welcome to the Super Depreciation Calculator, enter your inventoy into the inventory tab, then go to the summary tab to find the value of the inventory.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 54);
            label1.Name = "label1";
            label1.Size = new Size(409, 38);
            label1.TabIndex = 0;
            label1.Text = "Super Depreciation Calculator";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbxError);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dtpDateOut);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dtpDateIn);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tbxLifetime);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbxEndValue);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(tbxStartValue);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(tbxTitle);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnAdd);
            tabPage2.Controls.Add(btnRemove);
            tabPage2.Controls.Add(lbxInventory);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventory";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxError
            // 
            tbxError.Location = new Point(292, 306);
            tbxError.Multiline = true;
            tbxError.Name = "tbxError";
            tbxError.Size = new Size(456, 74);
            tbxError.TabIndex = 16;
            tbxError.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnDoubleDeclining);
            groupBox1.Controls.Add(rbnSingleLine);
            groupBox1.Location = new Point(289, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 123);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Depreciation Calculator";
            // 
            // rbnDoubleDeclining
            // 
            rbnDoubleDeclining.AutoSize = true;
            rbnDoubleDeclining.Location = new Point(20, 74);
            rbnDoubleDeclining.Name = "rbnDoubleDeclining";
            rbnDoubleDeclining.Size = new Size(146, 24);
            rbnDoubleDeclining.TabIndex = 1;
            rbnDoubleDeclining.TabStop = true;
            rbnDoubleDeclining.Text = "Double Declining";
            rbnDoubleDeclining.UseVisualStyleBackColor = true;
            // 
            // rbnSingleLine
            // 
            rbnSingleLine.AutoSize = true;
            rbnSingleLine.Location = new Point(20, 35);
            rbnSingleLine.Name = "rbnSingleLine";
            rbnSingleLine.Size = new Size(102, 24);
            rbnSingleLine.TabIndex = 0;
            rbnSingleLine.TabStop = true;
            rbnSingleLine.Text = "Single Line";
            rbnSingleLine.UseVisualStyleBackColor = true;
            // 
            // dtpDateOut
            // 
            dtpDateOut.Location = new Point(498, 259);
            dtpDateOut.Name = "dtpDateOut";
            dtpDateOut.Size = new Size(250, 27);
            dtpDateOut.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 262);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 13;
            label7.Text = "Date Out";
            // 
            // dtpDateIn
            // 
            dtpDateIn.Location = new Point(498, 211);
            dtpDateIn.Name = "dtpDateIn";
            dtpDateIn.Size = new Size(250, 27);
            dtpDateIn.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 214);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 11;
            label6.Text = "Date In";
            // 
            // tbxLifetime
            // 
            tbxLifetime.Location = new Point(623, 163);
            tbxLifetime.Name = "tbxLifetime";
            tbxLifetime.Size = new Size(125, 27);
            tbxLifetime.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 166);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 9;
            label5.Text = "Lifetime (years)";
            // 
            // tbxEndValue
            // 
            tbxEndValue.Location = new Point(623, 115);
            tbxEndValue.Name = "tbxEndValue";
            tbxEndValue.Size = new Size(125, 27);
            tbxEndValue.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 115);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 7;
            label4.Text = "End Value $";
            // 
            // tbxStartValue
            // 
            tbxStartValue.Location = new Point(623, 67);
            tbxStartValue.Name = "tbxStartValue";
            tbxStartValue.Size = new Size(125, 27);
            tbxStartValue.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 67);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Start Value $";
            // 
            // tbxTitle
            // 
            tbxTitle.Location = new Point(623, 19);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(125, 27);
            tbxTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(289, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add to Inventory";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(289, 258);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove from Inventory";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lbxInventory
            // 
            lbxInventory.FormattingEnabled = true;
            lbxInventory.Location = new Point(11, 16);
            lbxInventory.Name = "lbxInventory";
            lbxInventory.Size = new Size(255, 364);
            lbxInventory.TabIndex = 0;
            lbxInventory.MouseDoubleClick += lbxInventory_MouseDoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tbxSummary);
            tabPage3.Controls.Add(btnSummary);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Summary";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(290, 102);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(151, 28);
            btnSummary.TabIndex = 0;
            btnSummary.Text = "Calculate Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // tbxSummary
            // 
            tbxSummary.Location = new Point(230, 163);
            tbxSummary.Multiline = true;
            tbxSummary.Name = "tbxSummary";
            tbxSummary.Size = new Size(271, 88);
            tbxSummary.TabIndex = 1;
            tbxSummary.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Super Depreciation Calculator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox1;
        private Label label1;
        private TextBox tbxTitle;
        private Label label2;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lbxInventory;
        private Label label6;
        private TextBox tbxLifetime;
        private Label label5;
        private TextBox tbxEndValue;
        private Label label4;
        private TextBox tbxStartValue;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbnDoubleDeclining;
        private RadioButton rbnSingleLine;
        private DateTimePicker dtpDateOut;
        private Label label7;
        private DateTimePicker dtpDateIn;
        private Button btnSummary;
        private TextBox tbxError;
        private TextBox tbxSummary;
    }
}
