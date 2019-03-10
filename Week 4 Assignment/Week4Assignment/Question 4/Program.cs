using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.Write a program that prompts the user for a day of the week. 
 * The program will display a message based on the following table:
 * Choice	Message
 * Sun	"Home"
 * Mon	"Work"
 * Tue	"Work"
 * Wed	"Home"
 * Thu	"Work"
 * Fri	"Work"
 * Sat	"Work"
  */
namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What day of the week is it today? ");
            string day = Console.ReadLine();
            switch (day.ToLower())
            {
                case "sun":
                case "wed":
                    Console.WriteLine($"Home");
                    break;
                case "mon":
                case "tue":
                case "thu":
                case "fri":
                case "sat":
                    Console.WriteLine($"Work");
                    break;
                default:
                    Console.WriteLine($"Please check your input!");
                    break;

            }
        }
    }
}
