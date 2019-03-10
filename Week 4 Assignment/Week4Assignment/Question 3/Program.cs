using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *3.Write a program that prompts the user for the number of courses and residency status (domestic or international) and calculates tuition cost. 
 * Cost is calculated based on the table below.
 * Domestic	$325 per course
 * International	$1375 per course
 * You decide how you want the user to enter her/his residency status and prompt accordingly, also you should use named constants for the cost per course
 */
namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Processcing
            const int DOM = 325;
            const int INT = 1375;

            Console.Write("How many courses are you taking? ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's is your residency status? ");
            Console.WriteLine("(Enter D for domestic and I for international) ");
            char rs = Convert.ToChar(Console.ReadLine());

            switch (rs)
            {
                case 'D':
                    Console.WriteLine($"Your tuition cost is {DOM * course:C}");
                    break;
                case 'I':
                    Console.WriteLine($"Your tuition cost is {INT * course:C}");
                    break;
                default:
                    Console.WriteLine($"Please check your input!");
                    break;

            }
        }
    }
}
