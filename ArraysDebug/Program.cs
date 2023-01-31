/*
 * Arrays Debug
 * 1/31/2023
 * CE.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "orange", "grape", "watermelon",
                                "lime", "lemon", "pear", "pineapple", "banana" };
            for(int i = 1; i <= words.Length; i++)
            {
                Console.Write(words[i]);
            }
        }
    }
}
