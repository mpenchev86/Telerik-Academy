/*
Problem 15. Prime numbers
    • Write a program that finds all prime numbers in the range [ 1...10 000 000 ]. Use the Sieve of Eratosthenes algorithm.
*/

using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        List<int> primeNumbers = new List<int>();
        primeNumbers.Add(2);

        Console.Write("Prime numbers are: 2 ");
        for (int i = 3; i < 10000001; i++)
        {
            bool isPrime = true;
            foreach (int prime in primeNumbers)
            {
                if (prime * prime > i)
                {
                    break;
                }
                if (i % prime == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primeNumbers.Add(i);
                Console.Write(" {0}", i);
            }
        }
        Console.WriteLine();
        Console.WriteLine(primeNumbers.Count);
    }
}