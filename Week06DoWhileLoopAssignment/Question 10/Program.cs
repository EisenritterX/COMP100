using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *10.	A conversion table of Celsius to Fahrenheit temperature. 
 * The table must start with 100 Celsius and end at 0 Celsius with decrements of 10. 
 * (Fahrenheit = Celsiave a suitable us * 9/5 + 32). 
 * Your table must have  header and the values in the table must be right-align.
 */
namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel = 100;
            double fah;
            Console.WriteLine($"Celsius    Fahrenheit");
            do
            {
                fah = cel * 9 / 5 + 32;
                Console.WriteLine($"{cel,7}{fah,14:F1}");
                cel-= 10;
            }
            while (cel >= 0);
                    }
    }
}
