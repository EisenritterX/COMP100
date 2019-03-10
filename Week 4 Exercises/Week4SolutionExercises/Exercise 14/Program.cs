using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 14.	Write a program that calculates the tax on an item, based on the province code. 
 * Your program will prompt the user for the 2-letter province code, and the cost of the item and then computes the tax based on the following table:
 */
namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string pCode;
            //Output
            double cost;
            double tax;
            //Algorithm
            Console.Write("What is the province code? ");
            pCode = (Console.ReadLine());
            Console.Write("What is the cost of the item");
            cost = Convert.ToDouble(Console.ReadLine());
            if (pCode == "ON")
            {
                tax = 0.13 * cost;
                Console.WriteLine($"The tax of this item in Ontario is {tax:C}");
            }
            else if (pCode == "PQ")
            {
                tax = 0.14 * cost;
                Console.WriteLine($"The tax of this item is {tax:C}");
            }
            else
            {
                tax = 0;
                Console.WriteLine($"The tax of this item is {tax:C}");
            }

        }
    }
}
