using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 11.	A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years.
 * Write and run a C# program that computes and displays a depreciation table for seven years. 
 * The table should have the form: 
                           END-OF-YEAR         ACCUMULATED
YEAR      DEPRECIATION        VALUE           DEPRECIATION
----      ------------      ------------      ------------
 1            4000            24000               4000
 2            4000            20000               8000
 3            4000            16000              12000
 4            4000            12000              16000
 5            4000             8000              20000
 6            4000             4000              24000
 7            4000                0              28000
*/
namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 28000;
            int year = 1;
            const int dep = 4000;
            int aDep = 0;
            Console.WriteLine($"                           END-OF-YEAR         ACCUMULATED");
            Console.WriteLine("YEAR      DEPRECIATION        VALUE           DEPRECIATION");
            Console.WriteLine("----      ------------      ------------      ------------");
            do
            {
                fah = cel * 9 / 5 + 32;
                Console.WriteLine($"{year,2}{dep,12}{value}{fah,14:F1}");
                year++;
                value -= 4000;
            }
            while (value >= 0);
        }
    }
}
