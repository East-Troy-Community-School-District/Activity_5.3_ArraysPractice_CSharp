/*
 * Even Odd Array
 * 1/31/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int[] number = { 5, 2, 9, 3, 7, 1, 10, 11, 15, 12, 14 };
            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine("The array has " + evenCount + " even numbers.");
        }
    }
}
