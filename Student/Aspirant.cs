using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Aspirant : Student
    {
        public string ScientificWork { get; set; }

        public override int GetScholarship()
        {
            int scholarship1 = 2500;

            int scholarship2 = 2200;

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
