using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to calculate and display the potential difference between the ends of a wire.
 * The program will prompt the user for the current flowing and the resistance of the wire. 
 * (Potential difference is the product of the current and the resistance of the wire and may include a fractional part). 
 * 
 */
namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double current;
            double resistance;
            //Processing
            //Output
            double potDiff;
            //Algorithm
            Console.Write("What is the current going through the wire? ");
            current = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the resistance of the wire? ");
            resistance = Convert.ToDouble(Console.ReadLine());
            potDiff = current * resistance;
            Console.WriteLine($"The potential difference of the wire is {potDiff}");
        }
    }
}
