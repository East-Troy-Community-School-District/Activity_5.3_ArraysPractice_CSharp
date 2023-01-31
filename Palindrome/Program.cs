/*
 * Palindrome
 * 1/31/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, wordBackwards = "";
            Console.Write("Enter a word >> ");
            word = Console.ReadLine();

            for(int i = word.Length - 1; i >= 0; i--)
            {
                wordBackwards += word[i];
            }

            if (word == wordBackwards)
            {
                Console.WriteLine("That is a palindrome.");
            }
            else
            {
                Console.WriteLine("That is not a palindrome.");
            }
        }
    }
}
