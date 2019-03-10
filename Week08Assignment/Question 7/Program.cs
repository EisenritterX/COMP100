using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 7.	Write a program to produce a table of numbers from 10 to 1,
 * with their squares and cubes. Again, your table must look professional!
 */ 
namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number    Squared    Cubed");
            //int counter = 0;
            //while (counter < 10)
            //{
            //    counter++;
            //    Console.WriteLine($"{counter,6}{Math.Pow(counter,2),11}{Math.Pow(counter, 3),9}");
            //}
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"{counter,6}{Math.Pow(counter, 2),11}{Math.Pow(counter, 3),9}");
            }
        }
    }
}
