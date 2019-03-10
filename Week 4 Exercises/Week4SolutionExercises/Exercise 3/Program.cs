﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *3.If money is left in a particular bank for more than 5 years, the interest rate given by the bank is 7.5%, else the interest rate is 5.4%. 
 *  Write a program that prompt the user for the number of years that the money was left in the bank and display the appropriate interest rate depending on the value input.
 *  How many runs should you make to very that it works correctly?
 */
namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int years;
            //Algorithm
            Console.Write("How many years since the deposit was put in?");
            years = Convert.ToInt32(Console.ReadLine());
            if (years < 5)
            {
                Console.WriteLine($"The money has been deposited for {years} years. Your current interest rate is 5.4%");
            }
            else if (years >= 5)
            {
                Console.WriteLine($"The money has been deposited for {years} years. Your current interest rate is 7.5%");
            }
        }
    }
}
