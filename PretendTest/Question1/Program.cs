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
 * Question 1.
 * 16 Marks.
 *
 * Write a program that prompts the user for the name of a book 
 * and the number of books and then displays the following: 
 * "4 copies Introduction to Programming will cost $479.96"
 * [Assuming the inputs are "Introduction to Programming" and 4]
 * 
 * The cost of a book is $119.99 and it must be declared as a named constant
 * [Solution: Question1.exe]
 */
namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double price = 119.99;
            Console.WriteLine("What is the name of the book?");
            string bName = Console.ReadLine();
            Console.WriteLine("How many books do you like?");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{amount} copies of {bName} will cost {price*amount:C}");
        }
    }
}
