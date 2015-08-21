/*
Problem 11. Binary search
    • Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;

class BinarySearch
{
    static void Main(string[] args)
    {
                                                    /*------ Initialization ------*/
        Console.Write("Enter sorted array: ");
        string[] arrayString = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
        int[] arrayNumbers = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayNumbers[i] = int.Parse(arrayString[i]);
        }
        Console.Write("Enter element to find: ");
        int element = int.Parse(Console.ReadLine());
                                                    /*------ Binary search ------*/
        int indexStart = 0;                             // Where the array part, containing the number, begins
        int indexEnd = arrayNumbers.Length - 1;         // Where the array part, containing the number, ends
        int middle = -1;                                // The middle of the current array part

        while (true)
        {
            middle = (indexStart + indexEnd) / 2;
            if (arrayNumbers[middle] == element)
            {
                Console.WriteLine("The element index is: #{0}", middle);
                break;
            }
            else if (arrayNumbers[middle] > element)
            {
                indexEnd = middle;                      // The middle becomes the end of the next part, which is to be examined
            }
            else
            {
                if (indexStart == indexEnd - 1)         
                {
                    middle = indexEnd;                  // If the start and end indices are next to one another and the middle element is smaller than 'element', 'middle' should be increased with 1 and printed in the next iteration as a result
                    if (arrayNumbers[middle] != element)                // if the value on the new 'middle' index is different than the element we search for, then this element is not part of the array
                    {
                        Console.WriteLine("There's no such element.");
                        break;
                    }
                }
                indexStart = middle;                    // In the general case, where arrayNumbers[middle] < element, the middle becomes beginning for the next part to examine
            }
        }
    }
}