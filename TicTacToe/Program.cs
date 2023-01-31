/*
 * Tic Tac Toe
 * 1/31/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[ , ] board = {{"X", "O", "X"},
                                 {"X", "X", "O"},
                                 {"O", "X", "O"}};

            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("{0, -2}", board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
