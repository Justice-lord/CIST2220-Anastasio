using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstuctorDemo
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Student> students = new List<Student>();

            Student myStudent = new Student("S001", "John", "Smith");
            Console.WriteLine(myStudent.ToString());

            string doAnother;
            do
            {
                Student st = new Student();
                st.Firstname = GetInput("First Name");
                st.Lastname = GetInput("Last Name");
                st.Major = GetInput("Major");
                st.StudentNumber = GetInput("Student Number");
                st.Score1 = int.Parse(GetInput("Score 1"));
                st.Score2 = int.Parse(GetInput("Score 2"));
                st.Score3 = int.Parse(GetInput("Score 3"));
                students.Add(st);

                doAnother = GetInput("\nAdd another student? (y/n)");
            } while (doAnother == "y");

            Console.WriteLine("Student Averages: ");
            foreach (Student st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }

        private static string GetInput(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }
    }
}