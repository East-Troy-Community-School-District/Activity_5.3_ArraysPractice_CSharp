/*
 * Enter Same Value
 * 1/31/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterSameValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("How many words do you want to enter? >> ");
            length = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[length];

            for(int i = 0; i < words.Length; i++)
            {
                Console.Write("Enter a word >> ");
                words[i] = Console.ReadLine();
            }

            bool allSame = true;
            for(int i = 0; i < words.Length - 1; i++)
            {
                if(words[i] != words[i + 1])
                {
                    allSame = false;
                    break;
                }
            }
            if (allSame)
            {
                Console.WriteLine("Those are all the same word!");
            }
            else
            {
                Console.WriteLine("Those are not all the same word!");
            }
        }
    }
}
