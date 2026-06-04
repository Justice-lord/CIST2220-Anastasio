using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(String[] args)
        {
            string doAnother;
            do
            {
                Student st = new Student();
                string firstName = GetInput("First Name");
                st.SetStudentFirstName(firstName);
                string lastname = GetInput("Last Name");
                st.SetStudentLastName(lastname);
                Console.WriteLine("Majors: ");
                for(int i=0;i<Student.majors.Length;++i)
                {
                    Console.WriteLine((i + 1).ToString() + Student.majors[i]);
                }
                int majorIndex = int.Parse(GetInput("Majors"))-1;
                //string major = GetInput("Major");
                st.SetMajor(Student.majors[majorIndex]);
                string studentNum = GetInput("Student Number");
                st.SetStudentNumber(studentNum);
                int score1 = int.Parse(GetInput("Score 1"));
                st.SetScore1(score1);
                int score2 = int.Parse(GetInput("Score 2"));
                st.SetScore2(score2);
                int score3 = int.Parse(GetInput("Score 3"));
                st.SetScore3(score3);

                Console.WriteLine(st.GetSummary());

                doAnother = GetInput("\nDo another (y/n)");
            } while (doAnother == "y");
        }

        private static string GetInput(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }
    }
}
