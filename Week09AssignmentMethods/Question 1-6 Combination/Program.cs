using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1_6_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while ( choice != 0)
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) { 
                case 0:
                    break;
                case 3:
                        Console.WriteLine("How many numbers do you want to add?");
                        int numAmount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The Sum is {CalculateSum(numAmount)}");
                        Console.WriteLine();
                        continue;
                case 4:
                        Console.WriteLine("How many numbers do you want to add?");
                        int numInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The Sum of Squares is {CalculateSumOfSquares(numInput)}");
                        Console.WriteLine();
                        continue;
                case 5:
                        Console.WriteLine($"The Sum of Cubes is {CalculateSumOfCubes()}");
                        Console.WriteLine();
                        continue;
                case 6:
                        Console.WriteLine($"The Average of the Numbers is {CalculateAverage():F2}");
                        Console.WriteLine();
                        continue;
                default:
                        Console.WriteLine("Your Input is invalid. Please Try Again");
                        Console.WriteLine();
                        continue;
                }
            }
        }
        private static void DisplayMenu()
            {
                Console.WriteLine("Calculation Menu");
                Console.WriteLine("3) Calculate Sum");
                Console.WriteLine("4) Calculate Sum of Squares");
                Console.WriteLine("5) Calculate Sum of Cubes");
                Console.WriteLine("6) Calculate Average");
                Console.WriteLine("0) To Exit");
            }

            private static int CalculateSum(int numAmount)
            {
                int sum = 0;
                int num = 0;
                for (int i = 0; i < numAmount; i++)
                {
                    Console.WriteLine("What is the number?");
                    num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                }
                return sum;
            }

            private static int CalculateSumOfSquares(int numInput)
            {
                int sum = 0;
                int num = 0;
                for (int i = 0; i < numInput; i++)
                {
                    Console.WriteLine("What is the number?");
                    num = Convert.ToInt32(Console.ReadLine());
                    sum += num * num;
                }
                return sum;
            }

            private static int CalculateSumOfCubes()
            {
                Console.WriteLine("How many numbers are there");
                int numAmount = Convert.ToInt32(Console.ReadLine());
                int num = 0;
                int sum = 0;
                for (int i = 0; i < numAmount; i++)
                {
                    Console.WriteLine("What is the number");
                    num = Convert.ToInt32(Console.ReadLine());
                    sum += num * num * num;
                }
                return sum;
            }

            private static double CalculateAverage()
            {
                Console.WriteLine("How many numbers are there");
                int numAmount = Convert.ToInt32(Console.ReadLine());
                double num = 0;
                double sum = 0;
                for (int i = 0; i < numAmount; i++)
                {
                    Console.WriteLine("What is the number");
                    num = Convert.ToDouble(Console.ReadLine());
                    sum += num;
                }
                return Convert.ToDouble(sum / numAmount);
            }

        }
}
