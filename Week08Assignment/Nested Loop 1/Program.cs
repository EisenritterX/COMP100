﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *1.Write a C# program that calculates and displays the yearly amount available if $1,000 is invested in a bank account for 10 years.
 * Your program should display the amounts available for interest rates from 6 percent to 12 percent inclusively, at 1 percent increments. 
 * Use a nested loop, with the outer loop having a fixed count of 7 and the inner loop a fixed count of 10. 
 * The first iteration of the outer loop should use an interest rate of 6 percent and display the amount of money available at the end of the first 10 years. 
 * In each subsequent pass through the outer loop, the interest rate should be increased by 1 percent. 
 * Use the relationship that the money available at the end of each year equals the amount of money in the account at the start of the year
 * plus the interest rate times the amount available at the start of the year.
 * The output of this program should be in the form of a table. 
 */
namespace Nested_Loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000;
            double interest;
            for (interest = 1.06; interest <1.13; interest += 0.01)
            { 
                for (int year = 1; year<11; year++)
                {
                amount *= interest;
                Console.Write($"{amount:F} ");
                    if (year == 10)
                    {
                        amount = 1000;
                        Console.WriteLine();
                        continue;
                    }
                }
            }
        }
    }
}
