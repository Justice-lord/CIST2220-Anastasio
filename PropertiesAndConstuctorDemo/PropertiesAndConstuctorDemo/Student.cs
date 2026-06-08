using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstuctorDemo
{
    internal class Student
    {
        public static string[] majors = new string[] { "Programming", "Business", "Art History" };
        // fields private
        private int score1;
        private int score2;
        private int score3;

        // properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; private set; }

        public int Score1
        {
            get { return score1; }
            set
            {
                score1 = value;
                Calc();
            }
        }
        public int Score2
        {
            get { return score2; }
            set
            {
                score2 = value;
                Calc();
            }
        }
        public int Score3
        {
            get { return score3; }
            set
            {
                score3 = value;
                Calc();
            }
        }

        public override string ToString()
        {
            return
                Firstname + " " + Lastname
                + " Major: " + Major
                + " Average: " + Average;
        }

        private void Calc()
        {
            Average = (score1 + score2 + score3) / 3;
        }

        // constructors
        public Student() : this("Number Pending", "TBD", "TBD", -1, -1, -1, "Undeclared")
        {
        }

        public Student(String sID)
            : this(sID, "TBD", "TBD", -1, -1, -1, "Undeclared")
        {
        }

        public Student(string sID, string firstName, string lastName)
            : this(sID, firstName, lastName, -1, -1, -1, "Undeclared")
        {
        }

        public Student(string sID, string firstName, string lastName, int s1, int s2, int s3, string maj)
        {
            StudentNumber = sID;
            Firstname = firstName;
            Lastname = lastName;
            Score1 = s1;
            Score2 = s2;
            Score3 = s3;
            Major = maj;
        }

        /* destructor
        ~Student()
        {
            Console.WriteLine($"Student {StudentNumber} data no longer in memeory!");
        }

        // constuctors
        public Student()
        {
            StudentNumber = "Number Pending";
            Firstname = "TBD";
            Lastname = "TBD";
            Major = "Undeclared";
        }

        public Student(string sID)
        {
            StudentNumber = sID;
            Firstname = "TBD";
            Lastname = "TBD";
            Major = "Undeclared";
        }

        public Student(string sID, string firstName, string lastName)
        {
            StudentNumber = sID;
            Firstname= firstName;
            Lastname= lastName;
            Major = "Undeclared";
        }

        public Student(string sID, string firstName, string lastName, int s1, int s2, int s3, string maj)
        {
            StudentNumber = sID;
            Firstname = firstName;
            Lastname = lastName;
            Score1 = s1;
            Score2 = s2;
            Score3 = s3;
            Major = maj;
        }*/
       
    }
}
