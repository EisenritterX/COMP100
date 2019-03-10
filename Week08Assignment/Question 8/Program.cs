using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Write a program that displays a conversion table from Fahrenheit to Celsius.
 * The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment. 
 * Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value.
 * Your table must look professional!
 */ 
namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the starting Fahrenheit?");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Whats the ending Fahrenheit?");
            double end = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much you want to increment by?");
            double increment = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fahrenheit    Celsius");
            //while (start < end)
            //{

            //    Console.WriteLine($"{start,8:F2}°F{(start-32)*5/9,9:F2}°C");
            //    start += increment;
            for (;start<end; start+=increment)
            {

                Console.WriteLine($"{start,8:F2}°F{(start - 32) * 5 / 9,9:F2}°C");
                start += increment;
            }
        }
    }
}
