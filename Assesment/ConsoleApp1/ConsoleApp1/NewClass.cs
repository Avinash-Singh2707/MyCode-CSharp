using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NewClass 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(typeof(int));
            Console.WriteLine("ARRAY");
            TwoDimension();
            //Console.WriteLine("JAckked ARRAY");
            //JackedArray();
            //StringOps();
            //int total = 0, diff, mul, div;
            //total=Calculate(10,13,out diff,out mul, out div);
            //Console.WriteLine($"Sum od 10 and 13 {total}, product is {mul}, division is {div}, difference is {diff}");

            //Console.WriteLine(AddElement());  // calling with zero arguments
            //Console.WriteLine(AddElement(5));  // calling with 1 arguments
            //int total=AddElement(1,2,3,4,5);
            //Console.WriteLine("The total is {0}", total);

            //int n = 34;
            //CallValue(n);
            //Console.WriteLine($"The value of n : {n}");
            //CallRef(ref n);
            //Console.WriteLine($"The value of n : {n}");

            NewClass par = new NewClass();
            par.params_3(3,4.90f);
            par.params_3(3, 4.5f,6,7,8);
            Console.Read();

        }
        static void TwoDimension()
        {
            int[,] MyArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine("What???");
            Console.WriteLine(MyArray[1, 1]);  // print array at index at [1,1];

            // Two loops to iterate

            for(int i=0;i<MyArray.GetLength(0);i++)  // we can use arr.getlength(0) function to access 2D array 
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(MyArray[i, j] + " ");
                }
                Console.WriteLine();

            }

        }

        static void JackedArray()
        {
            // declare jacked array of two rows
            int[][] myjagg = new int[2][];
            //now let us set the size of each row, number of columns
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];
            // let us initialize jagged array
            myjagg[0][0] = 2;
            myjagg[0][1] = 3;
            myjagg[0][2] = 4;
            myjagg[1][0] = 6;
            myjagg[1][1] = 2;

            // Example to initialize the jagged array in different way
            int[][] jagg2 =
            {
                new int[]{1,2,3,4},
                new int[]{4,6},
                new int[]{3,4,5,}
            };

            // to display the element of the above jagged array

            for (int i = 0; i < jagg2.Length; i++) // size in terms of row -> jagg2.Length();
            {
                Console.WriteLine("Number of elments at row " + i + "is" + " " + jagg2[i].Length);
                for (int j = 0; j < jagg2[i].Length; j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void StringOps()
        {
            string s = "Hello";
            Console.WriteLine("First time s {0}", s.GetHashCode());  // it will genearte random no.
            s = "Hello world";
            Console.WriteLine("First time s {0}", s.GetHashCode());
            string s1 = "Csharp";
            Console.WriteLine("s1 is {0}", s1.GetHashCode());

            string s2 = s1;
            Console.WriteLine("s2 is {0}", s2.GetHashCode());

            string s3 = "Hello"; // both the data and reference are taken from the pool as the data is already present in the pool
            Console.WriteLine("s3 ref is same as s{0}", s3.GetHashCode());

            Console.WriteLine("Value of all string object");
            Console.WriteLine(s + " " + s1 + " " + s2 + " " + s3 + " ");
        }

        static void CallValue(int n)
        {
            n = 100;
            Console.WriteLine($"The value is {n}");  // String interpolation
        }
        static void CallRef(ref int n)
        {
            n = 100;
            Console.WriteLine($"The value is {n}");
        }

        // out keyword to return multiple values
        static int Calculate(int n1,int n2,out int sub, out int mul,out int div)  // static void
        {
            sub = n1 - n2;
            mul = n1 * n2;
            div = n1 / n2;
            return n1 + n2;
            // add=n1+n2;

        }
        static int AddElement(params int []arr)
        {
            int sum = 0;
            foreach(int n in arr)
            {
                sum = sum + n;
            }
            return sum;
        }
        public void params_3(int i,float f, params double[] arr)
        {
            //Console.WriteLine($"the value of i is {i} and the value of f is {f}");
            Console.WriteLine("the value of i is {0} and the value of f is {1}",i,f);  // Placehoder
            foreach (double z in arr)
                Console.WriteLine(z);
        }

    }

}
