namespace StudentFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string major = "TBD";

            if (rbProgramming.Checked) major = rbProgramming.Text;
            else if (rbWebDesign.Checked) major = rbWebDesign.Text;
            else if (rbIT.Checked) major = rbIT.Text;

            Student student = new Student(txbStudentID.Text, txbFirstName.Text, txbLastName.Text, major);

            int count = 0;
            if (cbxCIST101.Checked) count++;
            if (cbxCIST102.Checked) count++;
            if (cbxCIST103.Checked) count++;
            if (cbxCIST104.Checked) count++;

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;

            if (cbxCIST101.Checked)
            {
                courses[index] = cbxCIST101.Text;
                int.TryParse(tbxScore1.Text, out scores[index++]);
            }
            if (cbxCIST102.Checked)
            {
                courses[index] = cbxCIST102.Text;
                int.TryParse(tbxScore2.Text, out scores[index++]);
            }
            if (cbxCIST103.Checked)
            {
                courses[index] = cbxCIST103.Text;
                int.TryParse(tbxScore3.Text, out scores[index++]);
            }
            if (cbxCIST104.Checked)
            {
                courses[index] = cbxCIST104.Text;
                int.TryParse(tbxScore4.Text, out scores[index++]);
            }

            student.Scores = scores;
            student.Courses = courses;

            rtbResults.Text = student.ToString();
        }

    }
}
