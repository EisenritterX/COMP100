using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A confectionary store wants a program that will prompt the user for the price of the candy and the amount of money 
 * she would like to spend and then calculates and display the amount of candies that can be purchased.  
*/

namespace Q5_Confectionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double price;
            double budget;
            //processing
            //output
            double amount;
            //Algorithm
            Console.Write("The unit price of the candy  is: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much money do you have kid? ");
            budget = Convert.ToDouble(Console.ReadLine());
            amount = budget/price;
            Console.WriteLine($"With {budget:C}, the amount of candies you can buy is {amount:N0}");
            //string interpolation
            //must start with a dollar symbol
            //variable is encloase by a pair of braces
            Console.WriteLine($"The amount of candies you can buy is {amount}");
        }
    }
}
