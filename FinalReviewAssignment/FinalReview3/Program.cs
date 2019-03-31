using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReview3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static int CaculateDifference(int firstNumber, int secondNumber)
        {
            int difference = Math.Abs(firstNumber - secondNumber);
            return difference;
        }

        static double CalculatePower(double current, double resistance)
        {
            double power = Math.Pow(current, 2) * resistance;
            return power;
        }

        static double CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fee = numberOfCourses * costPerCourse + 15.25;
            return fee;
        }

        static double CalculateCommission(double saleAmount)
        {
            double commission = 0;
            if (saleAmount <= 1000)
            {
                return  commission;
            }
            else
            {
                return saleAmount * 0.01;
            }
        }

        static double CalculateTotalCost()
        {
            Console.WriteLine("How many burgers do you want to buy?");
            int numBurgers = Convert.ToInt32(Console.ReadLine());
            return numBurgers * 1.39;
        }

        static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            double G = 6.673e-11;

            return G*mass1*mass2/Math.Pow(distance,2);
        }

        static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Pow(s*(s-side1)*(s-side2)*(s-side3),0.5);
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return celsius*9/5+32;
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double ConvertCelsiusToKelvin(double celsius)
        {
            return celsius+273.15;
        }

        static double ConvertFahrenheitToKelvin(double fahrenheit)
        {
            return ConvertCelsiusToKelvin(ConvertFahrenheitToCelsius(fahrenheit));
        }

        static int Square(int a)
        {
            return a*a;
        }

        static int Cube(int a)
        {
            return a * a * a;
        }

        static double SalesAmountPrompt()
        {
            Console.WriteLine("What is your daily sales amount?");
            double saleAmount = Convert.ToDouble(Console.ReadLine());
            return saleAmount;
        }

        static double CalculateCommission2(double saleAmount)
        {
            double commission = 0;
            if (saleAmount < 1000)
            {
                return saleAmount*0.3;
            }
            else if (saleAmount>=1000 && saleAmount<3000)
            {
                return saleAmount * 0.4;
            }
            else if (saleAmount >= 3000)
            {
                return saleAmount * 0.5;
            }
            else
            {
                return 0;
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("================ Part 3 Question 1-13 =================");
            Console.WriteLine("|       1. Calculate Difference                      |");
            Console.WriteLine("|       2. Calculate Power                           |");
            Console.WriteLine("|       3. Calculate Tuition Fee                     |");
            Console.WriteLine("|       4. Calculate Commission                      |");
            Console.WriteLine("|       5. Calculate Burger Total Cost               |");
            Console.WriteLine("|       6. Calculate Gravitational Attraction        |");
            Console.WriteLine("|       7. Calculate Area of Triangle                |");
            Console.WriteLine("|       8. Celsius to Fahrenheit Conversion          |");
            Console.WriteLine("|       9. Fahrenheit to Celsius Conversion          |");
            Console.WriteLine("|      10. Celsius to Kelvin Conversion              |");
            Console.WriteLine("|      11. Fahrenheit to Kelvin Conversion           |");
            Console.WriteLine("|      12. Square then Cube                          |");
            Console.WriteLine("|      13. Calculate Commission Part 2               |");
            Console.WriteLine("|       0. Exit Program                              |");
            Console.WriteLine("======================================================");
            Console.WriteLine("          Enter the number of your choice ->          ");
        }

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
                        Console.WriteLine($"The difference between 3 and 5 is {CaculateDifference(3, 5)}");
                        Console.WriteLine($"The difference between 13 and 5 is {CaculateDifference(13, 5)}");
                        Console.WriteLine($"The difference between 23 and 5 is {CaculateDifference(23, 5)}");
                        Console.WriteLine($"The difference between 23 and 13 is {CaculateDifference(23, 13)}");
                        continue;
                    case 2:
                        Console.WriteLine($"IF current is 1.00A and Resistance is 1.50ohms then power will be {CalculatePower(1, 1.5):f2}W");
                        Console.WriteLine($"IF current is 0.10A and Resistance is 100.00ohms then power will be {CalculatePower(0.1, 100):f2}W");
                        continue;
                    case 3:
                        Console.WriteLine($"1 courses @$500.00 will cost a total of {CaculateTuitionFee(1, 500):c}");
                        Console.WriteLine($"5 courses @$450.00 will cost a total of {CaculateTuitionFee(5, 450):c}");
                        Console.WriteLine($"5 courses @$449.99 will cost a total of {CaculateTuitionFee(5, 449.99):c}");
                        Console.WriteLine($"5 courses @$no cost supplied will cost a total of {CaculateTuitionFee(5):c}");
                        continue;
                    case 4:
                        Console.WriteLine($"A sale amount of $900.00 will yield a commission of {CalculateCommission(900):c}");
                        Console.WriteLine($"A sale amount of $1000.00 will yield a commission of {CalculateCommission(1000):c}");
                        Console.WriteLine($"A sale amount of $2000.00 will yield a commission of {CalculateCommission(2000):c}");
                        continue;
                    case 5:
                        Console.WriteLine($"First call gives {CalculateTotalCost():c}");
                        Console.WriteLine($"Second call gives {CalculateTotalCost():c}");
                        continue;
                    case 6:
                        Console.WriteLine($"The Gravitational Attraction between Earth and Moon is {CalculateGravitationalAttraction(5.972e24, 7.348e22, 384400000):g3}");
                        continue;
                    case 7:
                        Console.WriteLine($"The area of the triangle is {CalculateTriangleArea(5.83, 4.24, 8):f2}");
                        continue;
                    case 8:
                        Console.WriteLine($"c:0.00 f:{ConvertCelsiusToFahrenheit(0):f2}");
                        Console.WriteLine($"c:50.00 f:{ConvertCelsiusToFahrenheit(50):f2}");
                        Console.WriteLine($"c:100.00 f:{ConvertCelsiusToFahrenheit(100):f2}");
                        continue;
                    case 9:
                        Console.WriteLine($"f:0.00 f:{ConvertFahrenheitToCelsius(0):f2}");
                        Console.WriteLine($"f:32.00 f:{ConvertFahrenheitToCelsius(32):f2}");
                        Console.WriteLine($"f:212.00 f:{ConvertFahrenheitToCelsius(212):f2}");
                        continue;
                    case 10:
                        Console.WriteLine($"c:-196.00 k:{ConvertCelsiusToKelvin(-196):f2}");
                        Console.WriteLine($"c:0.00 k:{ConvertCelsiusToKelvin(0):f2}");
                        Console.WriteLine($"c:100.00 k:{ConvertCelsiusToKelvin(100):f2}");
                        continue;
                    case 11:
                        Console.WriteLine($"f:-196.00 k:{ConvertFahrenheitToKelvin(-196):f2}");
                        Console.WriteLine($"f:0.00 k:{ConvertFahrenheitToKelvin(0):f2}");
                        Console.WriteLine($"f:100.00 k:{ConvertFahrenheitToKelvin(100):f2}");
                        continue;
                    case 12:
                        Console.Write("Enter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Original number is {num}, after cubing the square: {Cube(Square(num))}");
                        continue;
                    case 13:
                        double salesAmount = SalesAmountPrompt();
                        double commission = CalculateCommission2(salesAmount);
                        Console.WriteLine($"Sales amount is {salesAmount}, the commission is: {commission}");
                        continue;
                    default:
                        continue;
                }

            }
        }

    }
}
