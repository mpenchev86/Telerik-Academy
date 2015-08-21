/*
Problem 3. Compare char arrays
    • Write a program that compares two  char  arrays lexicographically (letter by letter).
*/

using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {                                                       /*----------Initialization of first array----------*/
        Console.Write("Enter array1 size: ");
        int arr1Lenght = int.Parse(Console.ReadLine());
        char[] array1 = new char[arr1Lenght];
        Console.WriteLine("Enter array1 elements:");
        for (int i = 0; i < arr1Lenght; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }
                                                            /*----------Initialization of second array----------*/
        Console.Write("Enter array2 size: ");
        int arr2Lenght = int.Parse(Console.ReadLine());
        char[] array2 = new char[arr2Lenght];
        Console.WriteLine("Enter array2 elements:");
        for (int i = 0; i < arr2Lenght; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }
                                                            /*----------Comparison of size and element by element.----------*/
        if (arr1Lenght != arr2Lenght)
        {
            Console.WriteLine("Arrays are of different size.");
        }
        else
        {
            bool identical = true;
            for (int i = 0; i < arr1Lenght; i++)
            {
                identical = (array1[i] == array2[i] || array1[i] == array2[i] + 32 || array1[i] == array2[i] - 32);
                if (!identical)
                {
                    Console.WriteLine("The arrays differ at index #{0}.", i);
                }
            }
            if (identical)
            {
                Console.WriteLine("The arrays are identical.");
            }
        }

    }
}