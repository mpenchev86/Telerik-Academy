/*
Problem 2. Compare arrays
    • Write a program that reads two  integer  arrays from the console and compares them element by element.
*/

using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter arrays size: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array1 = new int[arrLenght];
        int[] array2 = new int[arrLenght];

        Console.WriteLine("Enter array1 elements:");
        for (int i = 0; i < arrLenght; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter array2 elements:");
        for (int i = 0; i < arrLenght; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        bool areIdentical = true;
        for (int i = 0; i < arrLenght; i++)
        {
            areIdentical = (array1[i] == array2[i]);
            if (!areIdentical)
            {
                Console.WriteLine("The arrays differ at index #{0}.", i);
                //break;
            }
        }

        if (areIdentical)
        {
            Console.WriteLine("The arrays are identical.");
        }
    }
}