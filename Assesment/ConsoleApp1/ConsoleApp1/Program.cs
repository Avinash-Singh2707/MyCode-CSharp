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
            Program pro = new Program();
            //pro.TwoDim();
            //pro.JaggedArray();
            //pro.Length_GetLength();
            switchCASE se = new switchCASE();  // 
            se.CheckGrades_With_Switch();
            Console.ReadLine();
        }
        public void TwoDim()   // taking input from user in 2D array and display them
        {
            int r, c;
            Console.WriteLine("Enter rows and columns: ");
            r = Convert.ToInt32(Console.ReadLine()); 
            c = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[r,c];  // Declaration of 2Darray
            // loop for taking input
            for (int i = 0; i < r; i++)
            {
                for(int j=0;j<c;j++)
                {
                    arr[i,j]= Convert.ToInt32(Console.ReadLine());
                    
                }
            }
            // For priting
            Console.WriteLine("The Given 2-D array is :  -----");
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void JaggedArray()
        {
            int r, c;
            Console.WriteLine("Enter the rows of jagge array: ");
            r = Convert.ToInt32(Console.ReadLine());
            int[][] jag = new int[r][];  // decalration of jagged array  
            // Now for columns
            for(int i=0;i<r;i++)
            {
                Console.WriteLine("Enter the number of columns in row " + i + ": ");
                c = Convert.ToInt32(Console.ReadLine());
                jag[i] = new int[c];
            }
            // Now taking input
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<jag[i].Length;j++)
                {
                    Console.WriteLine("Write Elemenst: -----");
                    jag[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Display---
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<jag[i].Length;j++)
                {
                    //Console.WriteLine("Printing Jagged Array ----");
                    Console.Write(jag[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public void Length_GetLength()
        {
            // declaration of 2D array
            int[,] MyArray = new int[2, 3] { {1,2,4},{3,4,5} };
            Console.WriteLine(MyArray.Length);  // return total number of items in an array
            Console.WriteLine(MyArray.GetLength(0)); // 


        }
    }
}
