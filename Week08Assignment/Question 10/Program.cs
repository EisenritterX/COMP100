using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 10.	Write a C program that continuously requests a grade. 
 * If the grade is 999, the program should exit the loop and display the sum, umber of valid grades and the average of the valid grades entered.
 * (You must NOT display an invalid message)
* If the grade is less than 0 or greater than 100, 
* your program should print an appropriate message informing the user that an invalid grade has been entered, 
*else the grade should be added to a total. 
*P.S. The value 999 is use to terminate the cycle and should not be used in any of the calculation. You must not display an “Invalid grade”
*/
namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade =0 ;
            int counter = 0;
            double totalGrade=0;
            //while (grade != 999)
            //{
            //    Console.WriteLine("What's your grade?(Enter 999 to terminate and show result)");
            //    grade = Convert.ToDouble(Console.ReadLine());
            //    if (grade > 100 && grade != 999 || grade < 0)
            //    {
            //        Console.WriteLine("Your Input is invalid, please input again.");
            //    }
            //    else if (grade == 999)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        counter++;
            //        totalGrade += grade;
            //    }
            //}
            //Console.WriteLine($"The sum of the grades is {totalGrade:F0}, number of valid input is {counter}, the average of the valid grades is {totalGrade / counter:F2}");

            for (; grade != 999;)
            {
                Console.WriteLine("What's your grade?(Enter 999 to terminate and show result)");
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade > 100 && grade != 999 || grade < 0)
                {
                    Console.WriteLine("Your Input is invalid, please input again.");
                }
                else if (grade == 999)
                {
                    break;
                }
                else
                {
                    counter++;
                    totalGrade += grade;
                }
            }
            Console.WriteLine($"The sum of the grades is {totalGrade:F0}, number of valid input is {counter}, the average of the valid grades is {totalGrade / counter:F2}");
        }
    }
    }
