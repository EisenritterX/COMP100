using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.Write a method with the following specifications:
 * name: CalculateSumOfSquares
 * arguments: int representing the number of input that will constitute the sum
 * return value: int representing the sum of the squares of its input
 * displays: the user prompts but NOT the sum of the squares
 * tasks: prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as specified by the argument. 
 * Returns the final sum 

 * In your main when the user enters 4 in response to the menu choices,
 * you will prompt the user for the number of inputs that she will be working with.
 * You will invoke this method with this value and display the resulting value.
 
 */
namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to add?");
            int numAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateSumOfSquares(numAmount));
        }

        private static int CalculateSumOfSquares(int numInput)
        {
            int sum = 0;
            int num = 0;
            for (int i = 0; i < numInput; i++)
            {
                Console.WriteLine("What is the number?");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num*num;
            }
            return sum;
        }
        
    }
}
