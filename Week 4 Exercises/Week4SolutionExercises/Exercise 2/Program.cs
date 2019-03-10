using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *2.Write a console-based program that prompts a user for an hourly pay rate. 
 *  If the value entered is less than $7.50 or greater than $49.99, display an error message;
 *  otherwise, display a message indicating that the rate is okay.
 */
namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double hrlyRate;
            //Algorithm
            Console.Write("What is your hourly rate?");
            hrlyRate = Convert.ToDouble(Console.ReadLine());
            if (hrlyRate < 7.50 || hrlyRate> 49.99)
            {
                Console.WriteLine("Error, you may be getting paid too little or too much");
            }
            else if(hrlyRate >= 7.50 && hrlyRate <= 49.99)
            {
                Console.WriteLine("You are geting paid the right amount");
            }

        }
    }
}
