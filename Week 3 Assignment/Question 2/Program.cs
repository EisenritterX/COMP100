using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Write a program that prompts the user for the number of siblings his has. 
 * The program should display a message, “I also have 4 siblings” (assuming that the user enters 4).
 */
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nSibling;
            //Processing
            //Output
            //Algorithm
            Console.Write("How many siblings do you have? ");
            nSibling = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I also have {nSibling} siblings");
        }
    }
}
