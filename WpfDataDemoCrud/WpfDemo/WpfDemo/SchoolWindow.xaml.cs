using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for SchoolWindow.xaml
    /// </summary>
    public partial class SchoolWindow : Window
    {
        School school;
        public SchoolWindow()
        {
            InitializeComponent();
            school = new School();
            lbCampuses.DisplayMemberPath = "Name";
            lbCampuses.ItemsSource = school.Campus.DefaultView;
            lbCourses.DisplayMemberPath = "Title";
            lbCourses.ItemsSource = school.Campus.DefaultView;
            lbMajor.DisplayMemberPath = "Title";
            lbMajor.ItemsSource = school.Major.DefaultView;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            StudentWindow studentWindow = new StudentWindow(newStudent);

            //StudentWindow studentWindow = new StudentWindow();
            //Student newStudent = studentWindow.Student;
            studentWindow.ShowDialog();
            if(studentWindow.DialogResult == true)
            {
                lbStudents.Items.Add(newStudent);
            }
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //lblCampus.Content = lbCampuses.SelectedItem.ToString()
                ;
        }

        private void btnCampusAddUpdate_Click(object sender, RoutedEventArgs e)
        {

            if (lbCampuses.SelectedItem == null)
            {
                string insStr = "INSERT INTO Campus(Name) VALUES(@Name)";
                string connStr = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand insCmd = new SqlCommand(insStr, conn);
                    insCmd.Parameters.AddWithValue("Name", tbxCampus.Text);
                    conn.Open();
                    insCmd.ExecuteNonQuery();
                }
            }
            else
            {
                string updStr = "UPDATE Campus SET Name = @Name WHERE CampusID = @CampusID";
                string connStr = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
                using (SqlConnection conn =new SqlConnection(connStr))
                {
                    SqlCommand updCmd = new SqlCommand(updStr, conn);
                    updCmd.Parameters.AddWithValue("Name", tbxCampus.Text);
                    int campusId = (int)((DataRowView)lbCampuses.SelectedItem)["CampusID"];
                    updCmd.Parameters.AddWithValue("CampusID", campusId);
                    conn.Open();
                    updCmd.ExecuteNonQuery();
                }
            }

            school.Refresh();
            lbCampuses.ItemsSource = school.Campus.DefaultView;
            lbCampuses.Items.Refresh();
        }

        private void btnCampusDelete_Click(object sender, EventArgs e)
        {
            if (lbCampuses.SelectedIndex != null)
            {
                string delStr = "DELETE FROM Campus WHERE CampusID = @CampusID";
                string connStr = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
                using (SqlConnection conn =  new SqlConnection(connStr))
                {
                    SqlCommand delCmd = new SqlCommand(delStr, conn);
                    int campusID = (int)((DataRowView)lbCampuses.SelectedItem)["CampusID"];
                    delCmd.Parameters.AddWithValue("CampusID", campusID);
                    conn.Open();
                    delCmd.ExecuteNonQuery();
                }

                school.Refresh();
                lbCampuses.ItemsSource = school.Campus.DefaultView;
                lbCampuses.Items.Refresh();
            }
        }
    }
}
