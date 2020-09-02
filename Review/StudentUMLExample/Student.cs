using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUMLExample
{
    class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }

        private double BursarBalance;

        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 1000;

        }
        
        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            //BursarBalance = BursarBalance - amount;
            if (amount > 0)
            {
                BursarBalance -= amount;
            }
            else
            {
                throw new Exception();
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

    }
}
