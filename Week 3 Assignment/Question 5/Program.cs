using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to prompt the user to enter a single character. 
 * The program should display a message like “Your response was y”. F
 * or this question, you must use a variable of type char
 */
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            char input;
            //Processing
            //Output
            //Algorithm
            Console.Write("Enter your favorite letter? ");
            input = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Your response was {input}");
        }
    }
}
