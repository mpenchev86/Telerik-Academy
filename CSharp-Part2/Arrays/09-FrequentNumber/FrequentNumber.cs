/*
Problem 9. Frequent number
    • Write a program that finds the most frequent number in an array.
*/

using System;

class FrequentNumber
{
    static void Main(string[] args)
    {
                                                                /*------ Array Initialization ------*/
        Console.Write("Enter array: ");
        string[] arrayString = Console.ReadLine().Split(' ');
        int[] arrayNumbers = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayNumbers[i] = int.Parse(arrayString[i]);
        }
                                                                /*-------- Declaration of used variables --------*/
        int indexStart = 0;                     // Index of first occurrence
        int indexEnd = -1;                      // Index of last occurrence
        int mostCount = -1;                     // Stores the greatest last-first index difference
        int mostNumber = 0;                     // Stores the current most frequent number

                                                                /*-------- Sorting and counting occurrences --------*/
        Array.Sort(arrayNumbers);

        while (indexEnd < arrayNumbers.Length)                              // If the last occurrence of a number in a sorted array is the last position in the array, then this is the last number to be checked
        {
            indexEnd = Array.LastIndexOf(arrayNumbers, arrayNumbers[indexStart]);               // The last index for the current number is found
            if (indexEnd - indexStart > mostCount)                                              // If it's more frequent than the previous most frequent, the current number replaces the old
            {
                mostCount = indexEnd - indexStart;
                mostNumber = arrayNumbers[indexStart];
            }
            indexStart = indexEnd + 1;                                      // The starting index shifts for the next iteration to the first position after the ending index of the current number
            indexEnd = indexStart;                                          // The ending index for the next number cannot come before its starting index
        }
                                                                /*------ Printing ------*/
        Console.WriteLine("The most frequent number is: {0}, occurs {1} times", mostNumber, mostCount + 1);
    }
}