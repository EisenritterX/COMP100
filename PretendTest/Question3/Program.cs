using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #1 Fall 2018      =========================
 * 
 * Name:
 * Student ID:
 *
 * Question 3.
 * 14 Marks.
 *
 * Write a program that prompt the user for a single integer. 
 * The program will display if the number is a multiple of
 * 2 or 3 or both or neither 2 nor 3. Use the modulus (%) to check
 * for divisibility
 * 
 * You must use an if statement for this solution
 * 
 * [Solution: Question3.exe]
 */
namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the integer");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine("The number is both a multiple of 2 and 3.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is both a multiple of 2.");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is both a multiple of 3.");
            }
            else
            {
                Console.WriteLine("The number is neither divisible by 2 or 3.");
            }
        }
    }
}
