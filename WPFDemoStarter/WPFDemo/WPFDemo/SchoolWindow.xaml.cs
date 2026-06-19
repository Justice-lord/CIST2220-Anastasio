using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        School school = new School();

        public SchoolWindow()
        {
            InitializeComponent();
            lbxCampuses.ItemsSource = school.Campuses;
            lbxCourses.ItemsSource = school.Courses;
            lbxMajors.ItemsSource = school.Majors;
            lbxStudents.ItemsSource = school.Students;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            MainWindow studentWindow = new MainWindow(newStudent);
            studentWindow.ShowDialog();
            if (studentWindow.DialogResult == true)
            {
                MessageBox.Show($"Student {newStudent.StudentNumber} Added!");
                school.Students.Add(newStudent);
                lbxStudents.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Dialog Cancelled");
            }
        }

        private void btnSaveStudentList_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                {
                    foreach (var student in school.Students)
                    {
                        file.WriteLine(student.ToString());
                    }
                }
            }
        }
    }
}
