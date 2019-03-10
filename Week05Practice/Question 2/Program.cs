using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *2.	Write a program to produce a table that starts at a 
 * Celsius value of -10 and ends with a Celsius value of 60, 
 * in increments of ten degrees.  
 */
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = -10;
            do
            {
                Console.WriteLine($"{temp}");
                temp += 10;
            }
            while (temp <= 60);
            
        }
    }
}
