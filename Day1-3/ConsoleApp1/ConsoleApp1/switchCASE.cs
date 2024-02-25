using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class switchCASE
    {
        public void CheckGrades_With_Switch()
        {
            char grade; int marks;
            Console.WriteLine("Enter Grade and maths Score");
            grade = Convert.ToChar(Console.ReadLine());
            marks = Convert.ToInt32(Console.ReadLine());
            switch (marks)
            {
                case int mar when (marks >= 90 && marks <= 100 && grade == 'O'):
                    Console.WriteLine("outstanding");
                    break;
                case int mar when (marks >= 80 && marks < 90 && grade == 'E'):
                    Console.WriteLine("Excellent");
                    break;
                case int mar when (marks >= 60 && marks < 80 && grade == 'G'):
                    Console.WriteLine("Very Good");
                    break;
                case int mar when (marks >= 50 && marks < 60 && grade == 'C'):
                    Console.WriteLine("Good");
                    break;
                case int mar when (marks >= 40 && marks < 50 && grade == 'D'):
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }

    }
}
