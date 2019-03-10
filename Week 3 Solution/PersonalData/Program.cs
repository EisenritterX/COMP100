using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for a name , Social Insurance Number, hourly pay rate and the number of hours worked. 
 * In an attractive format display all the input data as well as the following: 
 * Gross pay is hourly pay rate times hours worked
 * Federal tax is 15 percent of gross pay
 * Provincial tax is 10 percent of gross pay
 * Net pay is gross minus federal and provincial taxes
 */
namespace PersonalData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            String firstName;
            String lastName;
            String SIN;
            double hrlyPay;
            double hrsWorked;
            //Processing
            //Output
            double grossPay;
            double fedTax;
            double provTax;
            double netPay;
            //Algorithm
            Console.Write("What's your first name? ");
            firstName = (Console.ReadLine());
            Console.Write("What's your last name? ");
            lastName = (Console.ReadLine());
            Console.Write("Please enter your SIN number: ");
            SIN = (Console.ReadLine());
            Console.Write("What's your hourly pay rate? ");
            hrlyPay = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many hours you worked this week? ");
            hrsWorked = Convert.ToDouble(Console.ReadLine());
            grossPay = hrlyPay*hrsWorked;
            fedTax = grossPay*0.15;
            provTax = grossPay * 0.10;
            netPay = grossPay - fedTax - provTax;
            Console.WriteLine();
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine($"Social Insurance Number: {SIN}");
            Console.WriteLine($"Hourly Pay Rate: {hrlyPay:C}");
            Console.WriteLine($"Hours worked last week: {hrsWorked}");
            Console.WriteLine();
            Console.WriteLine($"Payroll summary for {firstName} {lastName}");
            Console.WriteLine($"You worked {hrsWorked} hours at {hrlyPay:C} last week");
            Console.WriteLine();
            Console.WriteLine($"Gross Pay:              {grossPay,8:C}");
            Console.WriteLine($"Federal Tax:            {fedTax,8:C}");
            Console.WriteLine($"Provicial Tax:          {provTax,8:C}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Net Pay:                {netPay,8:C}");
        }
    }
}
