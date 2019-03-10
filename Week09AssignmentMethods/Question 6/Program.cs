using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.	Write a method with the following specifications:
 * name: CalculateAverage
 * arguments: none
 * return value: double representing the mathematical average of its inputs
 * displays: the user prompts but NOT the average
 * tasks: prompt the user for the number of inputs that she will be working with. 
 * Prompts the user for the required number of inputs. 
 * Calculate and return the average of the inputs. 
 * Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes.
 * In your main when the user enters the appropriate choice in response to the menu choices, you will invoke this method and display the resulting value.
 */


namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static double CalculateAverage()
        {
            Console.WriteLine("How many numbers are there");
            double numAmount = Convert.ToDouble(Console.ReadLine());
            double num = 0;
            double sum = 0;
            for (int i = 0; i < numAmount; i++)
            {
                Console.WriteLine("What is the number");
                num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            return sum/numAmount;
        }  
    }
}
