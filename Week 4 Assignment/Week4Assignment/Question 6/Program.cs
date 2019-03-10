using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 6.Saturdays and Wednesdays are Narendra’s days off. 
 * Write a program to prompt the user for the day of the week. 
 * The program will display “Home day” or “Work day” depending on the input. 
 * You and must use the following enum declaration: enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
 */
namespace Question_6
{
    class Program
    {
        enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun }

        static void Main(string[] args)
        {
            Console.Write("What day of the week is it today? (Enter 0-6)");
            int weekday = Convert.ToInt32(Console.ReadLine());
            Days day = (Days)(weekday);
            switch (day)
            {
                case Days.Mon:
                case Days.Tue:
                case Days.Thu:
                case Days.Fri:
                case Days.Sun:
                    Console.WriteLine("Work Day");
                    break;
                case Days.Wed:
                case Days.Sat:
                    Console.WriteLine("Home Day");
                    break;
                default:
                    Console.WriteLine($"Please check your input!");
                    break;

            }
        }
    }
}
