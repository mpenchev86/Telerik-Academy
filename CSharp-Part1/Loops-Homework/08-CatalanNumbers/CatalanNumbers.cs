/*
Problem 8. Catalan Numbers
    • In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
    • Write a program to calculate the  n  th  Catalan number by given  n  (0 ≤ n ≤ 100). 
*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter 'n' (0 ≤ n ≤ 100): ");
        byte n = byte.Parse(Console.ReadLine());
        if (n > 100)
        {
            Console.WriteLine("Invalid number.");
            return;
        }
        
        double product = 1;                     // In the loop below, the product sometimes takes floating-point values.
        for (int i = 2; i <= n; i++)
        {
            product *= ((double)(n + i)) / i;
        }
        
        Console.WriteLine("product: {0}", (BigInteger)product);         // The product always ends up being a whole number, so we convert it to BigInteger.
    }
}