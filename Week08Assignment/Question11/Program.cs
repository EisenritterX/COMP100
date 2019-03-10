using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 11.	Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user. 
 * For example, if the user enters an a and a z, the program should print all the characters between a and z and their respective numerical values.
 * Make sure that the second character entered by the user occurs later in the alphabet than the first character. 
 * If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
 *Your output should be formatted as shown below
*Letter	Decimal	Octal	Hex
* 	  a	     97	  141	 61
* 	  b	     98	  142	 62
* 	  c	     99	  143	 63
* 	  d	    100	  144	 64
* 	  e	    101	  145	 65
*to obtain an int from a char use an explicit cast
*to obtain an octal from an int use Convert.ToString(«number_value», 8)
*to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)
 */
namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Whats the starting character?");
            int sChar = (int)Convert.ToChar(Console.ReadLine());
            Console.Write("Whats the ending character?");
            int eChar = (int)Convert.ToChar(Console.ReadLine());
            while (eChar < sChar)
            {
                Console.Write("Input Invalid. Whats the ending character?");
                eChar = (int)Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("What type of loop would you like to see?");
            string loopType = Console.ReadLine().ToLower();
            Console.WriteLine("Letter   Decimal   Octal   Hex");

            switch (loopType)
            {
                case "while":
                    while (sChar < eChar + 1)
                    {

                        //Explicitly covnvert sChar back to Char Type, Convert it to Oct and make it String, and Convert it to Hex and make it String and displays it
                        //The respective paddings are 6, 10, 8 , 16 to make it fit with table
                        Console.WriteLine($"{(char)sChar,6}{sChar,10}{Convert.ToString(sChar, 8),8}{Convert.ToString(sChar, 16).ToUpper(),6}");
                        sChar++;
                    }
                    break;

                case "for":
                    for (; sChar < eChar + 1;)
                    {
                        //Explicitly covnvert sChar back to Char Type, Convert it to Oct and make it String, and Convert it to Hex and make it String and displays it
                        //The respective paddings are 6, 10, 8 , 16 to make it fit with table
                        Console.WriteLine($"{(char)sChar,6}{sChar,10}{Convert.ToString(sChar, 8),8}{Convert.ToString(sChar, 16).ToUpper(),6}");
                        sChar++;
                    }
                    break;
            }

        }
  
    }
}
