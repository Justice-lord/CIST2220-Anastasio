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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Assignment> tempScores = new List<Assignment>();
        public MainWindow()
        {
            InitializeComponent();
            lbxCourses.ItemsSource = tempScores;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Student st = new Student();

            st.FirstName = tbxFirstName.Text;
            st.LastName = tbxLastName.Text;
            st.StudentNumber = tbxStudentNum.Text;
            st.Major = tbxMajor.Text;

            txbResults.Text = st.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assign = new Assignment();
            assign.Title = tbxTitle.Text;
            assign.Score = int.Parse(tbxScore.Text);
            tempScores.Add(assign);
            lbxCourses.Items.Refresh();
        }
    }
}