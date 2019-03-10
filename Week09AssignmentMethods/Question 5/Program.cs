using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.Write a method with the following specifications:
 * name: CalculateSumOfCubes
 * arguments: none
 * return value: int representing the sum of the cubes of its input
 * displays: the user prompts but NOT the sum of the cubes 
 * tasks: 
 * •	prompt the user for the number of inputs that she will be working with
 * •	Prompts the user for their input
 * •	Accumulates the sum of the cubes input
 * •	Repeat the above two steps are many times as required
 * •	Returns the final sum 
 * In your main when the user enters 5 in response to the menu choices, you will invoke this method and display the resulting value.
 */
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        private static int CalculateSumOfCubes()
        {
            Console.WriteLine("How many numbers are there");
            int numAmount = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int sum = 0;
            for(int i = 0; i< numAmount; i++)
            {
                Console.WriteLine("What is the number");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num * num * num;
            }
            return sum;
        } 
    }
}
