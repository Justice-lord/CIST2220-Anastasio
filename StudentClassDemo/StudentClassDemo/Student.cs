using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Student
    {
        // fields private
        private string major;
        private string studentLastName;
        private string studentFisrtName;
        private string studentNumber;

        private int score1;
        private int score2;
        private int score3;

        // accessors
        public string GetMajor()
        {
            return major;
        }

        public string GetStudentLastName()
        {
            return studentLastName;
        }

        public string GetStudentFirstName()
        {
            return studentFisrtName;
        }

        public string GetStudentName()
        {
            return studentLastName + " " + studentFisrtName;
        }

        public string GetStudentNumber()
        {
            return studentNumber;
        }

        public int GetScore1()
        {
            return score1;
        }

        public int GetScore2()
        {
            return score2;
        }

        public int GetScore3()
        {
            return score3;
        }

        // mutator
        public void SetMajor(string newMajor)
        {
            this.major = newMajor;
        }

        public void SetStudentLastName(string newStudentLastName)
        {
            this.studentLastName = newStudentLastName;
        }

        public void SetStudentFirstName(string newStudentFirstName)
        {
            this.studentFisrtName = newStudentFirstName;
        }

        public void SetStudentNumber(string newStudentNumber)
        {
            this.studentNumber = newStudentNumber;
        }
        public void SetScore1(int newScore1)
        {
            this.score1 = newScore1;   
        }

        public void SetScore2(int newScore2)
        {
            this.score2 = newScore2;
        }

        public void SetScore3(int newScore3)
        {
            this.score3 = newScore3;
            Calc();
        }

        // read only attr
        private float average;

        public float GetAverage()
        {
            return average;
        }

        public string GetSummary()
        {
            return studentFisrtName + " " + studentLastName + " \n" + studentNumber + " Average: " + average;
        }

        private void Calc()
        {
            average = (score1 + score2 + score3) / 3;
        }
        // constructor
        public Student()
        {
            // default
        }
    }
}
