using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Adult ticket cost $3.75 and child ticket cost $2.25.
 * Write a program to prompt the user for the amount of adult and child ticket that she needs. 
 * The program will display a user friendly message of the number of tickets brought as well as the total cost.
 * (Use the "C" format-specifier for currency).
 */
namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double aAdult;
            double aChild;
            //Processing
            //Output
            double nTicket;
            double total;
            //Algorithm
            Console.Write("How many tickets do you need for childrens? ");
            aChild = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many tickets do you need for adult ? ");
            aAdult = Convert.ToInt32(Console.ReadLine());
            nTicket = aAdult+aChild;
            total = aAdult *3.75 +aChild*2.25;
            Console.WriteLine($"The total amount of tickets you require is {nTicket} and the cost in total is {total:C}.");
        }
    }
}
