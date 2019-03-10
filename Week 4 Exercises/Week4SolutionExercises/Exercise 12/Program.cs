using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*12.	Write a console-based program for a lawn-mowing service. 
 * The lawn-mowing season lasts 20 weeks.
 * The weekly fee for mowing a lot less than 400 square feet is $25. 
 * The fee for a lot that is 400 square feet or more, but less than 600 square feet, is $35 per week. 
 * The fee for a lot that is 600 square feet or over is $50 per week. 
 * Prompt the user for the length and width of a lawn, and then display the weekly mowing fee, as well as the total fee for the 20-week season. 
 */ 
namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double length;
            double width;
            //Algorithm
            Console.Write("What is the length of the lawn?");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the width of the lawn?");
            width = Convert.ToDouble(Console.ReadLine());
            if (length*width >= 400 && length * width <= 50)
            {
                Console.WriteLine("Accept");
            }
            else if (ats >= 80)
            {
                Console.WriteLine("Accept");
            }
        }
    }
}
