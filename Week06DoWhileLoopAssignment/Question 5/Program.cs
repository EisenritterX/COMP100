using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5.	To display the numbers 10 … 40 on separate lines with an asterisk before each multiples of 7. (asterisk besides multiples)
 */ 
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            do
            {
                if (counter % 7 == 0)
                {
                    Console.WriteLine($"{counter}*");
                }
                else
                    Console.WriteLine(counter);
                counter++;
            }
            while (counter < 41);
        }
    }
}
