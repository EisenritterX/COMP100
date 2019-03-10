using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *2. Modify your main so that the above method is call repeatedly. The program will terminate when the user enters 0. 
 *   Any other choice should produce an error message. 
 *   Because you will not be doing any arithmetic 
 *   you may accept the user response either as an int, or a char or a string. 
 */
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 8; i != 0;)
            {
                DisplayMenu();
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
        }

    }
}
