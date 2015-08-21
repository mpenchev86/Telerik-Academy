/*
Problem 7. Calculate N! / (K! * (N-K)!)
    • In combinatorics, the number of ways to choose  k  different members out of a group of  n  different elements (also known as the 
      number of combinations) is calculated by the following formula: (formula) . For example, there are 2598960 ways to withdraw 5 cards out 
      of a standard deck of 52 cards.
    • Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  n  and  k  (1 < k < n < 100). Try to use only two loops.
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

        BigInteger dividend = 1;
        BigInteger divisor = 1;

        for (int i = 1; i < n + 1; i++)
        {
            if (i > k)
            {
                dividend *= i;
            }
            if (i < n - k + 1)
            {
                divisor *= i;
            }
        }
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", (dividend / divisor));
    }
}