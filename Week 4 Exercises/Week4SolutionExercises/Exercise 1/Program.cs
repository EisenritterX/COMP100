using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *1.	Write a console-based program that prompts the user for an hourly pay rate. If the value entered is less than $7.50, display an error message 
 */

namespace Exercise_1
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
            if ( hrlyRate < 7.50)
            {
                Console.WriteLine("Error, you are getting paid under minimum wage!");
            } 
                
        }
    }
}
