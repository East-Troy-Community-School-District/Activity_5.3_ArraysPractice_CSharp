/*
 * Count Words Starting with B
 * 1/31/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsStartingWithB
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] words = { "bumfuzzle", "hullaballoo", "meldrop",
                               "bumbershoot", "smicker", "biblioklept",
                               "lollygag", "bamboozled", "cattywampus",
                               "smaze", "blubber" };
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0] == 'b')
                {
                    count++;
                }
            }
            Console.WriteLine("There are " + count + " words that start with \"b\".");
        }
    }
}
