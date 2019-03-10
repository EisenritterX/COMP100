using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for two integers.
 * The program will display the result of summing and finding the difference. 
 * (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5)
 */ 
namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n1;
            int n2;
            //processing
            //output
            int sum;
            int diff;
            //algorithm
            Console.Write("Please enter number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2;
            diff = n1 - n2;
            Console.WriteLine($"{n1}+{n2}={sum}");
            Console.WriteLine($"{n1}-{n2}={diff}");
        }
    }
}
