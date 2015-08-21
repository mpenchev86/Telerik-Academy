/*
Problem 11. Random Numbers in Given Range
    • Write a program that enters  3  integers  n ,  min  and  max  ( min != max ) and prints  n  random numbers in the range  [min...max] .
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
 */

using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer 'n': ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter integer 'min': ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter integer 'max': ");
        int max = int.Parse(Console.ReadLine());
        if (min >= max)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Random j = new Random();
        Console.Write("Random numbers: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", j.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}