namespace StudentFormDemo
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
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txbStudentID = new TextBox();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            groupBox1 = new GroupBox();
            rbIT = new RadioButton();
            rbWebDesign = new RadioButton();
            rbProgramming = new RadioButton();
            lblCourses = new Label();
            lblScores = new Label();
            cbxCIST101 = new CheckBox();
            cbxCIST102 = new CheckBox();
            cbxCIST103 = new CheckBox();
            cbxCIST104 = new CheckBox();
            tbxScore1 = new TextBox();
            tbxScore2 = new TextBox();
            tbxScore3 = new TextBox();
            tbxScore4 = new TextBox();
            btnSubmit = new Button();
            rtbResults = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(33, 21);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(79, 20);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(33, 57);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(33, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            txbStudentID.Location = new Point(138, 18);
            txbStudentID.Name = "txbStudentID";
            txbStudentID.Size = new Size(125, 27);
            txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(138, 54);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(125, 27);
            txbFirstName.TabIndex = 4;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(138, 90);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(125, 27);
            txbLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbIT);
            groupBox1.Controls.Add(rbWebDesign);
            groupBox1.Controls.Add(rbProgramming);
            groupBox1.Location = new Point(33, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Major";
            // 
            // rbIT
            // 
            rbIT.AutoSize = true;
            rbIT.Location = new Point(43, 86);
            rbIT.Name = "rbIT";
            rbIT.Size = new Size(42, 24);
            rbIT.TabIndex = 2;
            rbIT.TabStop = true;
            rbIT.Text = "IT";
            rbIT.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            rbWebDesign.AutoSize = true;
            rbWebDesign.Location = new Point(43, 56);
            rbWebDesign.Name = "rbWebDesign";
            rbWebDesign.Size = new Size(110, 24);
            rbWebDesign.TabIndex = 1;
            rbWebDesign.TabStop = true;
            rbWebDesign.Text = "Web Design";
            rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbProgramming
            // 
            rbProgramming.AutoSize = true;
            rbProgramming.Location = new Point(43, 26);
            rbProgramming.Name = "rbProgramming";
            rbProgramming.Size = new Size(121, 24);
            rbProgramming.TabIndex = 0;
            rbProgramming.TabStop = true;
            rbProgramming.Text = "Programming";
            rbProgramming.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.Location = new Point(344, 21);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(60, 20);
            lblCourses.TabIndex = 7;
            lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(462, 21);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(52, 20);
            lblScores.TabIndex = 8;
            lblScores.Text = "Scores";
            // 
            // cbxCIST101
            // 
            cbxCIST101.AutoSize = true;
            cbxCIST101.Location = new Point(344, 54);
            cbxCIST101.Name = "cbxCIST101";
            cbxCIST101.Size = new Size(88, 24);
            cbxCIST101.TabIndex = 9;
            cbxCIST101.Text = "CIST 101";
            cbxCIST101.UseVisualStyleBackColor = true;
            // 
            // cbxCIST102
            // 
            cbxCIST102.AutoSize = true;
            cbxCIST102.Location = new Point(344, 90);
            cbxCIST102.Name = "cbxCIST102";
            cbxCIST102.Size = new Size(88, 24);
            cbxCIST102.TabIndex = 10;
            cbxCIST102.Text = "CIST 102";
            cbxCIST102.UseVisualStyleBackColor = true;
            // 
            // cbxCIST103
            // 
            cbxCIST103.AutoSize = true;
            cbxCIST103.Location = new Point(344, 126);
            cbxCIST103.Name = "cbxCIST103";
            cbxCIST103.Size = new Size(88, 24);
            cbxCIST103.TabIndex = 11;
            cbxCIST103.Text = "CIST 103";
            cbxCIST103.UseVisualStyleBackColor = true;
            // 
            // cbxCIST104
            // 
            cbxCIST104.AutoSize = true;
            cbxCIST104.Location = new Point(344, 162);
            cbxCIST104.Name = "cbxCIST104";
            cbxCIST104.Size = new Size(88, 24);
            cbxCIST104.TabIndex = 12;
            cbxCIST104.Text = "CIST 104";
            cbxCIST104.UseVisualStyleBackColor = true;
            // 
            // tbxScore1
            // 
            tbxScore1.Location = new Point(462, 53);
            tbxScore1.Name = "tbxScore1";
            tbxScore1.Size = new Size(125, 27);
            tbxScore1.TabIndex = 13;
            // 
            // tbxScore2
            // 
            tbxScore2.Location = new Point(462, 89);
            tbxScore2.Name = "tbxScore2";
            tbxScore2.Size = new Size(125, 27);
            tbxScore2.TabIndex = 14;
            // 
            // tbxScore3
            // 
            tbxScore3.Location = new Point(462, 125);
            tbxScore3.Name = "tbxScore3";
            tbxScore3.Size = new Size(125, 27);
            tbxScore3.TabIndex = 15;
            // 
            // tbxScore4
            // 
            tbxScore4.Location = new Point(462, 161);
            tbxScore4.Name = "tbxScore4";
            tbxScore4.Size = new Size(125, 27);
            tbxScore4.TabIndex = 16;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(397, 217);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // rtbResults
            // 
            rtbResults.Location = new Point(344, 269);
            rtbResults.Name = "rtbResults";
            rtbResults.Size = new Size(424, 142);
            rtbResults.TabIndex = 19;
            rtbResults.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbResults);
            Controls.Add(btnSubmit);
            Controls.Add(tbxScore4);
            Controls.Add(tbxScore3);
            Controls.Add(tbxScore2);
            Controls.Add(tbxScore1);
            Controls.Add(cbxCIST104);
            Controls.Add(cbxCIST103);
            Controls.Add(cbxCIST102);
            Controls.Add(cbxCIST101);
            Controls.Add(lblScores);
            Controls.Add(lblCourses);
            Controls.Add(groupBox1);
            Controls.Add(txbLastName);
            Controls.Add(txbFirstName);
            Controls.Add(txbStudentID);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentID);
            ForeColor = SystemColors.InfoText;
            Name = "Form1";
            Text = "Student Info";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txbStudentID;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private GroupBox groupBox1;
        private RadioButton rbIT;
        private RadioButton rbWebDesign;
        private RadioButton rbProgramming;
        private Label lblCourses;
        private Label lblScores;
        private CheckBox cbxCIST101;
        private CheckBox cbxCIST102;
        private CheckBox cbxCIST103;
        private CheckBox cbxCIST104;
        private TextBox tbxScore1;
        private TextBox tbxScore2;
        private TextBox tbxScore3;
        private TextBox tbxScore4;
        private Button btnSubmit;
        private RichTextBox rtbResults;
    }
}
