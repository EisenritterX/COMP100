using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.	Write a program for a furniture company.
 * Ask the user to choose Pine Oak or Mahogany. 
 * Show the price of a table manufactured with the chosen wood Pine tables cost $100, Oak tables cost $225, and Mahogany tables cost $310. 
 * Use named constants and switch.
 */
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Processing
            const int PINE = 100;
            const int OAK = 225;
            const int MAHOGONY = 310;
            //Algorithm
            Console.Write("What wood would you like? Pine, Oak or Mahogany ");
            string wood = Console.ReadLine();
            switch (wood.ToLower())
            {
                case "pine":
                    Console.WriteLine($"The cost for pine tables are {PINE:C}.");
                    break;
                case "oak":
                    Console.WriteLine($"The cost for oak tables are {OAK:C}.");
                    break;
                case "mahogany":
                    Console.WriteLine($"The cost for mahogany tables are {MAHOGONY:C}.");
                    break;
            }
        }
    }
}
