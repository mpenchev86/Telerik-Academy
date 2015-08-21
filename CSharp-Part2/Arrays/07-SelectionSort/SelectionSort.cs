/*
Problem 7. Selection sort
    • Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    • Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move 
      it at the second position, etc.
*/

using System;
using System.Linq;

class SelectionSort
{
    static void Main(string[] args)
    {                                                       /*------ Array Initialization ------*/
        Console.Write("Enter array: ");
        string[] arrayString = Console.ReadLine().Split(new string[]{" ",","}, StringSplitOptions.RemoveEmptyEntries);
        int[] arrayInts = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayInts[i] = int.Parse(arrayString[i]);
        }
                                                            /*------- Sorting -------*/
        for (int j = 0; j < arrayInts.Length - 1; j++)
        {
            for (int i = j + 1; i < arrayInts.Length; i++)
            {
                if (arrayInts[i] < arrayInts[j])
                {
                    int tempMin = arrayInts[i];
                    arrayInts[i] = arrayInts[j];
                    arrayInts[j] = tempMin;
                }
            }
        }
                                                            /*------- Printing -------*/
        Console.Write("Sorted array: ");
        for (int i = 0; i < arrayInts.Length; i++)
        {
            if (i != arrayInts.Length - 1)
            {
                Console.Write("{0}, ", arrayInts[i]);
                continue;
            }
            Console.WriteLine(arrayInts[i]);
        }
    }
}