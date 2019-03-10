using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Create a program that prompts the user for her first name, middle initial and last name. 
 * The program will display the user name three times using the following three formats:
 * first name and last name
 * first name middle initial and last name
 * last name, first name and middle initial
 * For inputs Barack H Obama
 * Barack Obama
 * Barack H Obama
 * Obama, Barack H
 */
namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            String firstName;
            String lastName;
            String initial;
            //Processing
            //Output
            //Algorithm
            Console.Write("What's your first name? ");
            firstName = (Console.ReadLine());
            Console.Write("What's your last name? ");
            lastName = (Console.ReadLine());
            Console.Write("What's your middle initial?");
            initial = (Console.ReadLine());
            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine($"{firstName} {initial} {lastName}");
            Console.WriteLine($"{lastName}, {firstName} {initial}");
        }
    }
    }
}
