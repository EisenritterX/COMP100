using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ==================      Test #1 Winter 2019      ==================
 * 
 * Name: Qian Long (George) Zhou
 * Student ID: 300613283
 *
 * Question 2b.
 * 12 Marks.
 *
 * Write a program that prompts the user for his current balance and his
 * name.The program displays his name and year end balance. You must 
 * match the  format exactly.
 * 
 * Hint: balance at the end of the year = current balance * 1.04;
 * [Solution: Question2B]
 */
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your current balance: ");
            double cBlance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name} your balance at the end of the year will be {cBlance*1.04:C}");
        }
    }
}
