/*
Problem 6. Calculate N! / K!
    • Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
    • Use only one loop.
*/

using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer 'n', where 1 < n < 100: ");
        byte n = byte.Parse(Console.ReadLine());
        Console.Write("Enter a positive integer 'k', where 1 < k < n < 100: ");
        byte k = byte.Parse(Console.ReadLine());
        if (n >= 100 || n <= 1 || k >= 100 || k <= 1 || k >= n)
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        BigInteger division = 1;
        for (int i = k; i < n; i++)                     // k! is part of n!, so we can eliminate them and only calculate the remaining part of n!
        {
            division = division * (i + 1);
        }
        Console.WriteLine("n! / k! = {0}", division);
    }
}