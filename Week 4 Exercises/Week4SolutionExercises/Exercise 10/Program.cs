using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10.	Write a console-based program that prompts a user for an hourly pay rate.
 * If the user enters values less than $7.50 or greater than $49.99, prompt the user again.
 * If the user enters an invalid value again, display an appropriate error message.
 * If the user enters a valid value on either the first or second attempt, 
 * display the pay rate as well as the weekly rate, 
 * which is calculated as 40 times the hourly rate. 
 */
namespace Exercise_10
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
                Console.WriteLine("Error, please enter again");
                double newHrlyRate;
                Console.Write("What is your hourly rate?");
                newHrlyRate = Convert.ToDouble(Console.ReadLine());
                if (newHrlyRate >= 7.50 && newHrlyRate <= 49.99)
                    Console.WriteLine("You are getting paid the right amount.");
                else
                    Console.WriteLine("Error. Program Ends.");

            }
            else if(hrlyRate >= 7.50 && hrlyRate <= 49.99)
            {
                Console.WriteLine("You are geting paid the right amount.");
            }
        }
    }
}
