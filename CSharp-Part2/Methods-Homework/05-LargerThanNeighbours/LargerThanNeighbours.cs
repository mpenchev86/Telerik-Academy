/*
Problem 5. Larger than neighbours
    • Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.Write("Enter array: ");
        int[] array = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Console.Write("Enter position in array (0...n): ");
        int index = int.Parse(Console.ReadLine());
        CompareToNeighbours(array, index);
    }

    private static void CompareToNeighbours(int[] array, int index)
    {
        if (index < 0 || index > array.Length - 1)
        {
            Console.WriteLine("This position doesn't exist.");
            return;
        }

        if (index >= 1 && index <= array.Length - 2)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                Console.WriteLine("Element on postion #{0} IS larger than its neighbours.", index);
            }
            else
            {
                Console.WriteLine("Element on postion #{0} IS NOT larger than its neighbours.", index);
            }
        }
        else
        {
            Console.WriteLine("Element on postion #{0} doesn't have two neighbours.", index);
        }
    }
}
