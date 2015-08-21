/*
Problem 6. First larger than neighbours
    • Write a method that returns the index of the first element in array that is larger than its neighbours, or  -1 , if there’s no such element.
    • Use the method from the previous exercise.
*/

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.Write("Enter array: ");
        int[] array = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        if (FindFirst(array) != -1)
        {
            Console.WriteLine("The first element larger than its neighbours is on index #{0}", FindFirst(array));
        }
        else
        {
            Console.WriteLine("There's no such element.");
        }
        
    }

    private static int FindFirst(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (CompareToNeighbours(array, i))
            {
                return i;
            }
        }

        return -1;
    }

    private static bool CompareToNeighbours(int[] array, int index)
    {

        if (index >= 1 && index <= array.Length - 2)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}