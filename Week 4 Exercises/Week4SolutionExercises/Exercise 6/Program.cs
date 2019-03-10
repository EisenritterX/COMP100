using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *6.Write a console-based program that prompts the user for an hourly pay rate and hours worked. 
 * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax)
 */ 
namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double hrlyWage;
            double hrsWorked;
            //Output
            double grossPay;
            double netPay;
            //Algorithm
            Console.Write("How many hours you worked?");
            hrsWorked = Convert.ToDouble(Console.ReadLine());
            Console.Write("What's your hourly wage?");
            hrlyWage = Convert.ToDouble(Console.ReadLine());
            //Processing
            grossPay = hrsWorked * hrlyWage;
            if (grossPay <= 300)
            {
                netPay = grossPay - grossPay * .10;
                Console.WriteLine($"Your gross pay is {grossPay}, your netpay is {netPay}.");
            }
            else if (grossPay > 300)
            {
                netPay = grossPay - grossPay * .12;
                Console.WriteLine($"Your gross pay is {grossPay}, your netpay is {netPay}.");
            }
            
         }
    }
}
