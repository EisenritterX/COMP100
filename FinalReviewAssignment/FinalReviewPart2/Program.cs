using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }

        static void CalcDispVolume(double radius)
        {
            double volume = (Math.PI) * (Math.Pow(radius, 3) * 4 / 3);
            Console.WriteLine($"A sphere with radius of {radius} will have a volume of {volume:f2}");
        }
        static void ProvTaxCalculator(double itemP, string provC)
        {
            switch (provC.ToUpper())
            {
                case "ON":
                    Console.WriteLine($"The tax on an item {itemP:C} in {provC} will be {itemP * 0.13:C}");
                    break;
                case "QC":
                    Console.WriteLine($"The tax on an item {itemP:C} in {provC} will be {itemP * 0.17:C}");
                    break;
                default:
                    Console.WriteLine($"The tax on an item {itemP:C} in {provC} will be {0:C}");
                    break;
            }
        }

        static void TempConversion(double startTemp)
        {
            for (int i = 0; i < 10; i++)
            {
                double fahrenheit = 9 / 5 * startTemp + 32;
                Console.WriteLine($"{startTemp,3}{fahrenheit,20:f2}");
                startTemp += 1;
            }
        }

        static void MileKMConversion(double startKM, double increment, int size)
        {
            for (int i = 0; i < size; i++)
            {
                double miles = startKM * 0.621371;
                Console.WriteLine($"{startKM,5}{miles,20:f2}");
                startKM += increment;
            }
        }
        static void DisplaySineTable(double startValue, double stepSize, double rowNum)
        {
            for (int i = 0; i < rowNum; i++)
            {
                Console.WriteLine($"{startValue,5:f2}{Math.Sin(startValue),10:f4}");
                startValue += stepSize;
            }
        }
        static void CMToM(int cm)
        {
            int meter = cm / 100;
            int remain = cm % 100;
            Console.WriteLine($"{cm,3}cm{meter,20}m{remain,3}cm");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("================ Part 2 Question 1-8 =================");
            Console.WriteLine("|       1. Display Horizontal Stars                  |");
            Console.WriteLine("|       2. Calculate Vertical Stars                  |");
            Console.WriteLine("|       3. Calculate and Display Volume              |");
            Console.WriteLine("|       4. Calculate and Display Tax                 |");
            Console.WriteLine("|       5. Celsius Fahrenheit Table                  |");
            Console.WriteLine("|       6. KM to Mile Table                          |");
            Console.WriteLine("|       7. Display Sine Table                        |");
            Console.WriteLine("|       8. Height Conversion                         |");
            Console.WriteLine("|       0. Exit Program                              |");
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
                        DisplayHorizontalStars(0);
                        DisplayHorizontalStars(5);
                        DisplayHorizontalStars(10);
                        continue;
                    case 2:
                        DisplayVerticalStars(0);
                        DisplayVerticalStars(5);
                        DisplayVerticalStars(10);
                        continue;
                    case 3:
                        CalcDispVolume(1);
                        CalcDispVolume(2);
                        CalcDispVolume(10);
                        continue;
                    case 4:
                        ProvTaxCalculator(10, "on");
                        ProvTaxCalculator(1, "ON");
                        ProvTaxCalculator(20, "qC");
                        ProvTaxCalculator(100, "Qc");
                        ProvTaxCalculator(25, "bc");
                        continue;
                    case 5:
                        TempConversion(10);
                        TempConversion(50);
                        TempConversion(95);
                        continue;
                    case 6:
                        MileKMConversion(10, 1, 5);
                        MileKMConversion(1, 0.5, 5);
                        MileKMConversion(10, 10, 5);
                        continue;
                    case 7:
                        DisplaySineTable(0, 0.1, 15);
                        continue;
                    case 8:
                        CMToM(90);
                        CMToM(120);
                        CMToM(275);
                        continue;
                    default:
                        continue;
                }

            }
        }
    }
}

