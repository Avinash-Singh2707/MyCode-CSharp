using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avi this side");
            //Console.Read();
            Program program = new Program();  // creation an object of the Program class
            //program.Type_conversion();
            CheckGrades_With_Switch();
            Console.Read();
        }
        public void Type_conversion()
        {
            int i = 100;
            Console.WriteLine(i);
            float f = i;          // Implicit conversion
            Console.WriteLine(f);

            string str = "100gms";
            //int x = int.Parse(str);  // throw an exception mixed number and char

            int res;
            bool success = int.TryParse(str, out res);
            // res will give output, str is input, it will not throws an exception, either true or false status
            //Console.WriteLine("Value of X after parsing is " + x);

            if (success)
                Console.WriteLine("The parsed number is {0}", res);
            else
                Console.WriteLine("Invalid data could not parsed");
            //Console.Read();

        }

        static void CheckGrades_With_Switch()
        {
            char grade; int marks;
            Console.WriteLine("Enter Grade and maths Score");
            grade = Convert.ToChar(Console.ReadLine());
            marks = Convert.ToInt32(Console.ReadLine());
            switch (marks)
            {
                case int mar when (marks >=90 && marks <= 100 && grade=='O'):
                    Console.WriteLine("outstanding");
                    break;
                case int mar when (marks >= 80 && marks < 90 && grade=='E'):
                    Console.WriteLine("Excellent");
                    break;
                case int mar when (marks >= 60 && marks < 80 && grade == 'G'):
                    Console.WriteLine("Very Good");
                    break;
                case int mar when (marks >= 50 && marks < 60 && grade=='C'):
                    Console.WriteLine("Good");
                    break;
                case int mar when (marks >= 40 && marks < 50 && grade=='D'):
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }
    }
}
