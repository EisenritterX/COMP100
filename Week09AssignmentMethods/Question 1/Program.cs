using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	Write a method with the following specifications:
*name: DisplayMenu
*arguments: none
*return value: none
*tasks: display the following menu choice on the screen

*Calculation Menu
*3) Calculate Sum 
*4) Calculate Sum of Squares
*5) Calculate Sum of Cubes
*0) To Exit

*Enter the number that corresponds to your choice: 

*You may beautify the output to your own likings. You don’t have to implement the functionalities of the various menu choices at this stage
*Call this method from your main.
 
 */
namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
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
