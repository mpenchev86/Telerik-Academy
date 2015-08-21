/*
Problem 4. Binary search
    • Write a program, that reads from the console an array of  N  integers and an integer  K , sorts the array and using the method  
      Array.BinSearch()  finds the largest number in the array which is ≤  K . 
*/

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter array lenght: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        string[] input = Console.ReadLine().Split(new string[]{" ", ",", "\t"}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < N; i++)
        {
            array[i] = Convert.ToInt32(input[i]);
        }

        Console.Write("Enter integer number K: ");
        int K = int.Parse(Console.ReadLine());

        Array.Sort(array);

        int index = Array.BinarySearch(array, K);

        if (index < 0)
        {
            index = ~index;

            if (index != 0)
            {
                Console.WriteLine(array[index - 1]);
            }
            else if (index != array.Length)
            {
                Console.WriteLine(array[index]);
            }
        }
        else
        {
            Console.WriteLine(array[index]);
        }
    }
}