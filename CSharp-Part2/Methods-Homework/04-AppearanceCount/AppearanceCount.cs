/*
Problem 4. Appearance count
    • Write a method that counts how many times given number appears in given array.
    • Write a test program to check if the method is workings correctly.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class AppearanceCount
{
    static void Main(string[] args)
    {
        Console.Write("Enter array length: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.Write("Enter numbers: ");
        array = Console.ReadLine()
            .Split(new char[]{' ',',','\t'}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Console.Write("Enter number to search for: ");
        int number = int.Parse(Console.ReadLine());

        CountAppearance(array, number);
    }

    private static void CountAppearance(int[] array, int number)
    {
        int counter = 0;
        foreach (int item in array)
        {
            if (number == item)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} appears {1} times in the array.", number, counter);
    }
}