using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 3.Write a method with the following specifications:
 * name: CalculateSum
 * arguments: int representing the number of inputs that will constitute the sum
 * return value: int representing the sum of its inputs
 * displays: only the prompt for the user inputs, but does not display the sum 
 * tasks: prompt and accepts inputs (as many as specified by the argument), and sum them, Finally the method will return the sum of all the inputs (the sum) 
 */
namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to add?");
            int numAmount = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(CalculateSum(numAmount));
        }

        private static int CalculateSum(int numAmount)
        {
            int sum = 0;
            int num = 0;
            for (int i = 0; i < numAmount;i++)
            {
                Console.WriteLine("What is the number?");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            return sum;
        }

    }
}
