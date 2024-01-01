using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public double AverageMark { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string group, double averageMark)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            AverageMark = averageMark;
        }

        public virtual int GetScholarship()
        {
            int scholarship1 = 2000;

            int scholarship2 = 1900;

            if (AverageMark == 5)
            {
                Console.WriteLine($"Ваша стипендия {scholarship1} рублей");
            }
            else if (AverageMark < 5)
            {
                Console.WriteLine($"Ваша стипендия {scholarship2} рублей");
            }
            int result = scholarship1;


            return result;

        }
    }
}
