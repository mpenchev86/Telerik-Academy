/*
Problem 6. Sum integers
    • You are given a sequence of positive integer values written into a string, separated by spaces.
    • Write a function that reads these values from given string and calculates their sum.
Example:

      input         output

"43 68 9 23 318"     461 

*/

using System;
using System.Linq;

class SumIntegers
{
    static void Main(string[] args)
    {
        Console.Write("Enter positive integer values, separated by spaces: ");
        string numbers = Console.ReadLine();
        CalculateSum(numbers);
    }

    private static void CalculateSum(string numbers)
    {
        long[] uintValues = numbers.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
        long result = uintValues.Sum();
        Console.WriteLine(result);
    }
}