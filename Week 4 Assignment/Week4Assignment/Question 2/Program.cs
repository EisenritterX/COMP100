using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.	Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers 
 * If it is S, subtract the second integer from the first 
 * else multiply the integers Display the results of the arithmetic
 */
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the first number? ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What's the second number? ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What's the arithmatic procedure? ");
            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case 'A':
                    Console.WriteLine($"The sum is {n1+n2}");
                    break;
                case 'S':
                    Console.WriteLine($"The difference is {n1-n2}");
                    break;
                default:
                    Console.WriteLine($"The product is {n1 * n2}");
                    break;

            }
        }
    }
}
