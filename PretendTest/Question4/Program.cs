using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #1 Fall 2018      =========================
 * 
 * Name:
 * Student ID:
 *
 * Question 4.
 * 11 Marks.
 *
 * Write a program that prompt the user for a single letter. 
 * If the letter is a vowel it displays the message "vowel"
 * else it displays the message "consonant". 
 * 
 * You must use a switch statement for this solution
 * 
 * [Solution: Question4.exe]
 */
namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the letter");
            char letter = Convert.ToChar(Console.ReadLine());
            switch (letter)
            {
              case 'a': 
              case 'e':
              case 'i':
              case 'o':
              case 'u':
                    {
                        Console.WriteLine("vowel");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("consonant");
                    }
                    break;

            }   
        }       
    }           
}               
