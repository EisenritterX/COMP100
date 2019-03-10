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
 * Question 5b.
 * 12 Marks.
 *
 * Enterprise Car Rentals has asked you to write a program that prompts 
 * the user for the type of rider. Based on the user's input the program 
 * will display the following:
 * 
 * Input: sedan
 * Message: sedan cost 21.40 per day
 * 
 * Input: COMPACT
 * Message: COMPACT cost 18.90 per day
 * 
 * Input: Sports
 * Message: Sports cost 32.80 per day
 * 
 * any other input
 * Message: I am sorry I don't know of that kind of car
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * You MUST USE A NESTED IF statement to solve this problem
 * [For full marks you need to accept all permutations of sedan, compact
 * and sports]
 * 
 * [Solution: Question5B]
 */
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is kind of car would you like to rent?");
            string car = Console.ReadLine();
            if (car.ToLower() == "sedan")
            {
                Console.WriteLine($"{car} cost 21.40 per day");
            }
            else if (car.ToLower() == "compact")
            {
                Console.WriteLine($"{car} cost 18.90 per day");
            }
            else if (car.ToLower() == "sport")
            {
                Console.WriteLine($"{car} cost 32.80 per day");
            }
            else
            {
                Console.WriteLine("I am sorry I don't know of that kind of car");
            }
        }
    }
}
