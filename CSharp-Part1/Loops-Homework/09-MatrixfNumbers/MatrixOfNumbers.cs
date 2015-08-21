/*
Problem 9. Matrix of Numbers
    • Write a program that reads from the console a positive integer number  n  (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
      Use two nested loops.
*/

using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer n (1 <= n <= 20): ");
        byte n = byte.Parse(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", j + i + 1);
            }
            Console.WriteLine();
        }
    }
}