using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1.	Write a method called DisplayPersonalInfo().
 * This method will display your name, school, program and your favorite course.
 * Call the DisplayPersonalInfo() method from your program Main() method
 *
 * 7.	In a write a method called DisplayMenu() to display the following text on screen:
 */

namespace FinalReviewPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        //Question 1 Method
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("George Zhou");
            Console.WriteLine("Centennial College");
            Console.WriteLine("3109-Game Programming");
            Console.WriteLine("COMP391-Introduction to Game & Simulation");
        }
        //Question 2 Method
        static void CalculateTuition()
        {
            Console.Write("How many courses are you taking?");
            double numCourse = Convert.ToDouble(Console.ReadLine());
            double cost = numCourse * 569.99;
            Console.WriteLine($"The cost for {numCourse} courses is {cost:C}");
        }
        //Question 3 Method
        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius;
            Console.WriteLine($"If the radius is {radius} then the area will be {area:f2}");
        } 
        //Question 4 Method
        static void CalculateAreaOfTriangle()
        {
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base: ");
            double baset = Convert.ToDouble(Console.ReadLine());
            double area = (baset*height)/2;
            Console.WriteLine($"The area will be {area:f2}");
        }
        //Question 5 Method
        static void CalculateSaleCommission()
        {
            Console.Write("What is your sales amount? ");
            double sales = Convert.ToDouble(Console.ReadLine());
            double commission = 0;
            if (sales > 1000)
                commission = sales * 0.25;
            Console.WriteLine($"The commission on {sales:C} is {commission}");
        }
        //Question 6 Method
        static void DisplaySineTable()
        {
            Console.WriteLine("Starting Value: ");
            double sValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Increment Value: ");
            double iValue = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{sValue,5:f2}{Math.Sin(sValue),10:f4}");
                sValue += iValue;
            }
        }
        //Question 7 Method       
        static void DisplayMenu()
        {
            Console.WriteLine("=============George’s Computer Systems================");
            Console.WriteLine("|       1. Display Personal Information              |");
            Console.WriteLine("|       2. Calculate Tuition                         |");
            Console.WriteLine("|       3. Calculate Area Of A Circle                |");
            Console.WriteLine("|       4. Calculate The Area Of A Triangle          |");
            Console.WriteLine("|       5. Calculate Sales Commission                |");
            Console.WriteLine("|       6. Display Sine Table                        |");
            Console.WriteLine("|       0. End program                               |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("======================================================");
            Console.WriteLine("          Enter the number of your choice ->          ");
        }
        //Question 8 Method
        static void ShowMenu()
        {
            int option = 999;
            while (option != 0)
            {
                DisplayMenu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        DisplayPersonalInfo();
                        continue;
                    case 2:
                        CalculateTuition();
                        continue;
                    case 3:
                        CalculateAreaOfCircle();
                        continue;
                    case 4:
                        CalculateAreaOfTriangle();
                        continue;
                    case 5:
                        CalculateSaleCommission();
                        continue;
                    case 6:
                        DisplaySineTable();
                        continue;
                    default:
                        continue;
                }

            }
        }

    }
}
