using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *1.Write a program to print the numbers 2 to 10 in increments of two.
 * The output of your program should be 2 4 6 8 10 
 */
namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            for (int i =1;  i<= 5; i++)
            {
                Console.WriteLine($"{2*i}");
            }



        }
    }
}
