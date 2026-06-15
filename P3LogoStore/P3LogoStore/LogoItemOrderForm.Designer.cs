namespace P3LogoStore
{
    partial class LogoItemOrderForm
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
            label1 = new Label();
            tbxOrderNumber = new TextBox();
            label2 = new Label();
            tbxNumberOfItems = new TextBox();
            gbxItemType = new GroupBox();
            rbnUSB = new RadioButton();
            rbnMug = new RadioButton();
            rbnPen = new RadioButton();
            label3 = new Label();
            tbxTextOnItem = new TextBox();
            cbxHasLogo = new CheckBox();
            lblNumOfColors = new Label();
            tbxNumOfColors = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            tbxResults = new TextBox();
            gbxItemType.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Order Number";
            // 
            // tbxOrderNumber
            // 
            tbxOrderNumber.Location = new Point(174, 31);
            tbxOrderNumber.Name = "tbxOrderNumber";
            tbxOrderNumber.Size = new Size(125, 27);
            tbxOrderNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Number of Items";
            // 
            // tbxNumberOfItems
            // 
            tbxNumberOfItems.Location = new Point(174, 76);
            tbxNumberOfItems.Name = "tbxNumberOfItems";
            tbxNumberOfItems.Size = new Size(125, 27);
            tbxNumberOfItems.TabIndex = 3;
            // 
            // gbxItemType
            // 
            gbxItemType.Controls.Add(rbnUSB);
            gbxItemType.Controls.Add(rbnMug);
            gbxItemType.Controls.Add(rbnPen);
            gbxItemType.Location = new Point(445, 34);
            gbxItemType.Name = "gbxItemType";
            gbxItemType.Size = new Size(250, 125);
            gbxItemType.TabIndex = 4;
            gbxItemType.TabStop = false;
            gbxItemType.Text = "Item Type";
            // 
            // rbnUSB
            // 
            rbnUSB.AutoSize = true;
            rbnUSB.Location = new Point(25, 94);
            rbnUSB.Name = "rbnUSB";
            rbnUSB.Size = new Size(57, 24);
            rbnUSB.TabIndex = 2;
            rbnUSB.TabStop = true;
            rbnUSB.Text = "USB";
            rbnUSB.UseVisualStyleBackColor = true;
            // 
            // rbnMug
            // 
            rbnMug.AutoSize = true;
            rbnMug.Location = new Point(25, 61);
            rbnMug.Name = "rbnMug";
            rbnMug.Size = new Size(60, 24);
            rbnMug.TabIndex = 1;
            rbnMug.TabStop = true;
            rbnMug.Text = "Mug";
            rbnMug.UseVisualStyleBackColor = true;
            // 
            // rbnPen
            // 
            rbnPen.AutoSize = true;
            rbnPen.Location = new Point(25, 30);
            rbnPen.Name = "rbnPen";
            rbnPen.Size = new Size(53, 24);
            rbnPen.TabIndex = 0;
            rbnPen.TabStop = true;
            rbnPen.Text = "Pen";
            rbnPen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 136);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Text to print:";
            // 
            // tbxTextOnItem
            // 
            tbxTextOnItem.Location = new Point(44, 168);
            tbxTextOnItem.Multiline = true;
            tbxTextOnItem.Name = "tbxTextOnItem";
            tbxTextOnItem.Size = new Size(308, 77);
            tbxTextOnItem.TabIndex = 6;
            // 
            // cbxHasLogo
            // 
            cbxHasLogo.AutoSize = true;
            cbxHasLogo.Location = new Point(470, 170);
            cbxHasLogo.Name = "cbxHasLogo";
            cbxHasLogo.Size = new Size(72, 24);
            cbxHasLogo.TabIndex = 7;
            cbxHasLogo.Text = "Logo?";
            cbxHasLogo.UseVisualStyleBackColor = true;
            cbxHasLogo.CheckedChanged += cbxHasLogo_CheckedChanged;
            // 
            // lblNumOfColors
            // 
            lblNumOfColors.AutoSize = true;
            lblNumOfColors.Location = new Point(443, 221);
            lblNumOfColors.Name = "lblNumOfColors";
            lblNumOfColors.Size = new Size(127, 20);
            lblNumOfColors.TabIndex = 8;
            lblNumOfColors.Text = "Number of Colors";
            lblNumOfColors.Visible = false;
            // 
            // tbxNumOfColors
            // 
            tbxNumOfColors.Location = new Point(608, 218);
            tbxNumOfColors.Name = "tbxNumOfColors";
            tbxNumOfColors.Size = new Size(125, 27);
            tbxNumOfColors.TabIndex = 9;
            tbxNumOfColors.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(149, 268);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(478, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // tbxResults
            // 
            tbxResults.Location = new Point(59, 320);
            tbxResults.Multiline = true;
            tbxResults.Name = "tbxResults";
            tbxResults.Size = new Size(674, 118);
            tbxResults.TabIndex = 12;
            // 
            // LogoItemOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxResults);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(tbxNumOfColors);
            Controls.Add(lblNumOfColors);
            Controls.Add(cbxHasLogo);
            Controls.Add(tbxTextOnItem);
            Controls.Add(label3);
            Controls.Add(gbxItemType);
            Controls.Add(tbxNumberOfItems);
            Controls.Add(label2);
            Controls.Add(tbxOrderNumber);
            Controls.Add(label1);
            Name = "LogoItemOrderForm";
            Text = "Logo Item Orders";
            gbxItemType.ResumeLayout(false);
            gbxItemType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxOrderNumber;
        private Label label2;
        private TextBox tbxNumberOfItems;
        private GroupBox gbxItemType;
        private RadioButton rbnUSB;
        private RadioButton rbnMug;
        private RadioButton rbnPen;
        private Label label3;
        private TextBox tbxTextOnItem;
        private CheckBox cbxHasLogo;
        private Label lblNumOfColors;
        private TextBox tbxNumOfColors;
        private Button btnSubmit;
        private Button btnClear;
        private TextBox tbxResults;
    }
}
