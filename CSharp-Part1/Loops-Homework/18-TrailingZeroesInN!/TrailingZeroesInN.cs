/*
Problem 18.* Trailing Zeroes in N!
    • Write a program that calculates with how many zeroes the factorial of a given number  n  has at its end.
    • Your program should work well for very big numbers, e.g.  n=100000 .
*/

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 'n': ");
        long n = long.Parse(Console.ReadLine());

        int powerCount = 1;
        long trailingZero = 0;
        do
        {
            trailingZero += n / (long)Math.Pow(5, powerCount);
            powerCount++;
        } while (n >= (long)Math.Pow(5, powerCount));
        Console.WriteLine("Trailing zeroes are: {0}", trailingZero);
    }
}