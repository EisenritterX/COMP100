using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Write a method that takes an argument (a char array) and print each item on a single line separated by a space.
 * From your main, call this method with letters as argument
 *
 * 2. Write a method that takes an argument (an int array) and print each item on a single line separated by a space.
 * From your main, call this method with numbers as argument
 * 
 * 3. Write a method that takes an argument (a string array) and print each item on a single line separated by a space.
 * From your main, call this method with poem as argument
 * 
 * 4. In your main method use the method in question 1 to display the letters array,
 * then use the Array.Reverse() method to reverse the letters array and then again call the appropriate method to print it
 * 
 * 5. In your main method use the method in question 3 to display the poem array, 
 * then use the Array.Sort() method to sort the poem array and then again call the appropriate method to print it 
 * 
 * 6.In your main method use the method in question 2 to display the numbers array, then use the Array.Binarysearch() method to try to find the position of 3 in the numbers array.
 * What is your answer?
 * Now repeat the same steps after you have sorted the array and printed the sorted array
 * 
 *  7.	Write a method that creates and return an array of ints. The method takes a single int argument that represents the how many items will be in the resulting array and does the following:
 •	Declare an array of the required type
 •	Allocate memory for the intended number of items
 •	Using any looping structure, prompt the user for a number and then assign to each element. 
 *  In your main method do the following: (1) call this method (you will need to supply an argument), assign the resulting value to at suitable variable and then (2) display this variable.
 *  
 *  8.	Write another method that creates and return an array of ints. The method takes a single argument that represents the number of items in the resulting array and does the following:
 •	Declare an array of the required type
 •	Allocate memory for the intended number of items
 •	Using any looping structure, assign to each element a random integer in the range 100 to 200. 
 *  You will need the following statement in global scope.
 *  static Random rand = new Random();
 *  The following statement will give you a random letter
 *  rand.Next(100, 200);
 *  Exercise this method in a similar fashion as you did for question 7
 */

namespace Week11Array
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            LetterArray(letters);
            NumberArray(numbers);
            PoemArray(poem);

            Array.Reverse(letters);
            LetterArray(letters);

            Array.Sort(poem);
            PoemArray(poem);

            Console.WriteLine(Array.BinarySearch(numbers, 3));
            Array.Sort(numbers);
            Console.WriteLine(Array.BinarySearch(numbers, 3));

            Console.Write("How many numbers would you like to have in your interger array? ");
            int amount = Convert.ToInt32(Console.ReadLine());
            NumberArray(CreateIntArray(amount));

            Console.Write("How many numbers would you like to have in your random interger array? ");
            int amountRan = Convert.ToInt32(Console.ReadLine());
            NumberArray(CreateRandomIntArray(amountRan));

            Console.Write("How many numbers would you like to have in your random character array? ");
            int amountCRan = Convert.ToInt32(Console.ReadLine());
            LetterArray(CreateRandomCharArray(amountRan));
        }

        static void LetterArray(char[] letters)
        {
            foreach (char x in letters)
            {
                Console.Write(x+" ");  
            }
            Console.WriteLine();
        }

        static void NumberArray(int[] numbers)
        {
            foreach (int x in numbers)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }

        static void PoemArray(string[] poem)
        {
            foreach (string x in poem)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }

        static int[] CreateIntArray(int numItems)
        {
            int[] numbers = new int[numItems];
            for (int i =1; i <= numItems; i++)
            {
                Console.WriteLine($"What is the number {i}? ");
                numbers[i-1] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }

        static int[] CreateRandomIntArray(int numItems)
        {
            int[] numbers = new int[numItems];
            for (int i = 1; i <= numItems; i++)
            {
                numbers[i - 1] = rand.Next(100,200);
            }
            return numbers;
        }

        static char[] CreateRandomCharArray(int numItems)
        {
            char[] letters = new char[numItems];
            for (int i = 1; i <= numItems; i++)
            {
                letters[i - 1] = (char)rand.Next('A','Z');
            }
            return letters;
        }
    }
}
