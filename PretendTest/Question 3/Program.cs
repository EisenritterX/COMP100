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
 * Question 2.
 * 16 Marks.
 *
 * Write a program that prompt the user for two numbers and a letter. 
 * If the letter is a "+" then it display the message 
 * "The sum of 5 and 2 is 7" otherwise it displays the 
 * message "The difference between 5 and 2 is 3"
 * 
 * [Solution: Question2.exe]
 */
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number?");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the operation (enter + for addition)?");
            int operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"The sum of {n1} and {n2} is {n1 + n2}.");
                    break;
                default:
                    Console.WriteLine($"the difference between {n1} and {n2} is {n1-n2}");
                    break;
            }
        }
    }
}
