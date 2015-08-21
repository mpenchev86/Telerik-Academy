/*
Problem 13.* Merge sort
    • Write a program that sorts an array of integers using the Merge sort algorithm.
*/

using System;
using System.Text;
using System.Linq;

class MergeSort
{
    static void Main(string[] args)
    {
        Console.Write("Enter integers to sort: ");
        int[] array = Console.ReadLine()
            .Split(new string[] { " ", ",", "\t" }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        array = SortMerge(array);
        Console.WriteLine(string.Join(", ", array));
    }

    private static int[] SortMerge(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;    
        }

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        for (int i = 0; i < array.Length; i++)
        {
            if (i < middle)
            {
                left[i] = array[i];
            }
            else
            {
                right[i - middle] = array[i];
            }
        }

        left = SortMerge(left);
        right = SortMerge(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length; )
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++;
            }
        }

        for ( ; i < left.Length; i++)
        {
            result[i + j] = left[i];
        }

        for (; j < right.Length; j++)
        {
            result[i + j] = right[j];
        }

        return result;
    }

}