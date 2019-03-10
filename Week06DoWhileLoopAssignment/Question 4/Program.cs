using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.	To display the numbers 1 … 20 on separate lines with an asterisk after each multiples of 5. (multiples besides asterisk) 
 */ 
namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            do
            {
                if (counter%5 == 0)
                {
                    Console.WriteLine($"{counter}*");
                }
                else
                Console.WriteLine(counter);
                counter++;
            }
            while (counter < 21);
        }
    }
}
