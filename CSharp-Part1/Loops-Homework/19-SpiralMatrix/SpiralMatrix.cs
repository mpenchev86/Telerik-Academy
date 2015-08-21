/*
Problem 19.** Spiral Matrix
    • Write a program that reads from the console a positive integer number  n  (1 ≤ n ≤ 20) and prints a matrix holding the numbers from  
      1  to  n*n  in the form of square spiral like in the examples below.
*/

using System;
using System.Numerics;


class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter positive integer 1<=n<=20: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        int[,] arrayNxN = new int[n, n];
        int limRowCol = n - 1;
        int nextNum = 0;
        int rowOrCol = 0;

        do
        {
            if (n == 1)
            {
                arrayNxN[0, 0] = 1;
                break;
            }

            for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Row to the Right
            {
                nextNum++;
                arrayNxN[rowOrCol, i] = nextNum;
            }
            for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Column Down
            {
                nextNum++;
                arrayNxN[i, limRowCol - rowOrCol] = nextNum;
            }
            for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Row to the Left
            {
                nextNum++;
                arrayNxN[limRowCol - rowOrCol, limRowCol - i] = nextNum;
            }
            for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Column Up
            {
                nextNum++;
                arrayNxN[limRowCol - i, rowOrCol] = nextNum;
            }
            rowOrCol++;
            if (rowOrCol == limRowCol - rowOrCol)
            {
                arrayNxN[rowOrCol, rowOrCol] = ++nextNum;
            }
        } while (limRowCol > 2 * rowOrCol);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, -4}", arrayNxN[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}