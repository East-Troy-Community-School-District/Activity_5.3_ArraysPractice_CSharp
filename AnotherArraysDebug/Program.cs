/*
 * Another Arrays Debug
 * Pawelski
 * 10/22/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherArraysDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple, orange, grape, watermelon, lime, lemon, pear, pineapple, banana" };
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
