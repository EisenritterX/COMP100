using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void DisplayIntArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generator = new Random();
            int[] result =new int[numberOfItems];

            for (int i = 0; i< numberOfItems; i++)
            {
                result[i] = generator.Next(largestValue);
            }
            return result;
        }

        static int[] CountEvenOdd(int[] array)
        {
            int odd = 0;
            int even = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            int[] result = { odd, even };
            return result;
        }

        static int[] CalculateDigitFrequencies(int[] array)
        {  
            int[] result = new int[10];
            for (int j = 0; j < 10; j++)
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == j)
                    {
                        counter++;
                    }
                }
                result[j] = counter;
            }
            return result;
        }

        static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int[] result = new int[10];
            for (int j = 0; j < 10; j++)
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]%10 == j)
                    {
                        counter++;
                    }
                }
                result[j] = counter;
            }
            return result;
        }

         static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] result = new int[10];
            for (int j = 0; j < 10; j++)
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] / 10 == j)
                    {
                        counter++;
                    }
                }
                result[j] = counter;
            }
            return result;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("================ Part 4 Question 1-7 =================");
            Console.WriteLine("|       1. Display Int Array                         |");
            Console.WriteLine("|       2. Generate Random Array                     |");
            Console.WriteLine("|       3. Count Evens and Odds                      |");
            Console.WriteLine("|       4. calculate Digit Frequencies               |");
            Console.WriteLine("|       5. Calculate Last Digit Frequencies          |");
            Console.WriteLine("|       6. Calculate Bucket Number Frequencies       |");
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
                        int[]array = { 5 ,12,  8,  5,  7,  3,  5,  6,  9, 10, 16,  8, 11, 34,  9, 50, 12, 14, 45 };
                        DisplayIntArray(array);
                        continue;
                    case 2:
                        DisplayIntArray(GenerateRandomIntArray(15,10));
                        DisplayIntArray(GenerateRandomIntArray(25, 10));
                        DisplayIntArray(GenerateRandomIntArray(30, 100));
                        continue;
                    case 3:
                        int[] holder = GenerateRandomIntArray(20, 100);
                        DisplayIntArray(holder);
                        DisplayIntArray( CountEvenOdd(holder));
                        continue;
                    case 4:
                        holder = GenerateRandomIntArray(30, 10);
                        DisplayIntArray(holder);
                        DisplayIntArray(CalculateDigitFrequencies(holder));
                        continue;
                    case 5:
                        holder = GenerateRandomIntArray(30, 100);
                        DisplayIntArray(holder);
                        DisplayIntArray(CalculateLastDigitFrequencies(holder));
                        continue;
                    case 6:
                        holder = GenerateRandomIntArray(30, 99);
                        DisplayIntArray(holder);
                        DisplayIntArray(CalculateNumberFrequencies(holder));
                        continue;
                    default:
                        continue;
                }

            }
        }
    }
}
