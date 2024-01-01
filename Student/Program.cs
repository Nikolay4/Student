using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var aspirant = new Aspirant();

            var student1 = new Student();

            student1.AverageMark = 4;

            Student[] students = new Student[2] {aspirant, student1};

            Student[] students2 = new Student[]
            {
                new Student()
                {
                    AverageMark = 5,
                    Group = "Упм",
                },
                
                new Aspirant()
                {
                    AverageMark = 3.5,
                    Group = "УПП",
                    FirstName = "Костя",
                },
                new Student()
                {
                    AverageMark = 4,
                },
                new Student()
                {
                    AverageMark = 2,
                },
                aspirant,
                student1,
                new Student()
                {
                    AverageMark = 1,
                }
            };

            foreach (var student in students2)
            {
                student.GetScholarship();
            }
            
            

           


            

            

        }
    }
}
