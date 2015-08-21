/*
Problem 14. Quick sort
    • Write a program that sorts an array of strings using the Quick sort algorithm.
*/

using System;

class QuickSort
{
    static void Main(string[] args)
    {
                                                            /*------ Initialization ------*/
        Console.Write("Enter array: ");
        string[] arrayString = Console.ReadLine().Split(new string[] { " ", ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);
        int[] arrayNumbers = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayNumbers[i] = int.Parse(arrayString[i]);
        }
                                                            /*------- Sorting -------*/
        SortArrays(arrayNumbers, 0, arrayNumbers.Length - 1);
                                                            /*------- Printing ------*/
        Console.WriteLine(String.Join(", ", arrayNumbers));

    }
                                                            /*------ Recursive method for partitioning and sorting -------*/
    static void SortArrays(int[] arrayNumbers, int startIndex, int endIndex)
    {
        int tempNum;                                                    // It is used for switching values of elements in the array
        int indexSmaller = startIndex;                                  // This index points to where the next place for a smaller element is
        for (int i = startIndex; i < endIndex; i++)                         // Iterating through all elements in the current partition and comparing them with the last one
        {
            if (arrayNumbers[i] <= arrayNumbers[endIndex])                  // If they are smaller or equal to the last element, they are placed on the left side in the partition
            {
                tempNum = arrayNumbers[indexSmaller];
                arrayNumbers[indexSmaller] = arrayNumbers[i];
                arrayNumbers[i] = tempNum;
                indexSmaller++;
            }
        }
        tempNum = arrayNumbers[indexSmaller];                               // When all the elements are compared to the last one, that element is placed on the right side - next to the last moved(smaller) element
        arrayNumbers[indexSmaller] = arrayNumbers[endIndex];
        arrayNumbers[endIndex] = tempNum;

        if (startIndex < indexSmaller - 1)                                  // If there are more than one element in the left side of the current partition, we have to sort them and we use the same method
        {
            SortArrays(arrayNumbers, startIndex, indexSmaller - 1);
        }
        if (indexSmaller + 1 < endIndex)                                    // The same goes for the elements in the right side of the current partition. They are also sorted by comparing them to the last element in this right (sub)partition.
        {
            SortArrays(arrayNumbers, indexSmaller + 1, endIndex);
        }
    }
}