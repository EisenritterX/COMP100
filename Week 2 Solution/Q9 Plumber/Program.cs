using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Gerard-The Plumber bills customers by the length of the pipe as well as the number of joins that is needed. 
 * Write a program that prompts the user for the length of the pipe, the number of joins and the unit price per length and joins. 
 * The program calculates and displays the total cost of the job. You may use the inputs in checking your program. 
 * (length of pipe = 4m, price per meter = $1.25, number of joins = 5, price per join = $1.20. The total cost of the job will be $11.00)
 */ 


namespace Q9_Plumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double lPipe;
            double nJoins;
            double pPipe;
            double pJoins;
            //processing
            //output
            double total;
            //Algorithm
            Console.Write("What's the length of the pipe: ");
            lPipe = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many joins are there: ");
            nJoins = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the price of the pipe: ");
            pPipe = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the price of the join: ");
            pJoins = Convert.ToDouble(Console.ReadLine());
            total = lPipe*pPipe + nJoins*pJoins;
            Console.WriteLine($"Your total would be {total:C}");
        }
    }
}
