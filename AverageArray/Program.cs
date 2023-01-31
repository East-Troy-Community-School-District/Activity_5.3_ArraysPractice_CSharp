/*
 * Average Array
 * 1/31/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, average;
            double[] numbers = { 5.6, 77, 5.3, 8.49, 50.1, 66.2 };
            for(int i = 0; i < 6; i++)
            {
                sum += numbers[i];
            }
            average = sum / 6;
            Console.WriteLine("The average is " + average);
        }
    }
}
