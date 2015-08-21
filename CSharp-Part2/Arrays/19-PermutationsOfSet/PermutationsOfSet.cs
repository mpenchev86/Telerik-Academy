/*
Problem 19.* Permutations of set
    • Write a program that reads a number  N  and generates and prints all the permutations of the numbers [ 1 … N ].
*/

using System;

class PermutationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("Enter range limit N, [1...N]: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine("Permutations:");

        Permutation(array, 0, array.Length - 1);
    }

    private static void Permutation(int[] array, int index, int length)
    {
        if (index == length)
        {
            Console.WriteLine(string.Join(", ", array));
            return;
        }

        for (int i = index; i < array.Length; i++)
        {
            Swap(array, i, index);
            Permutation(array, index + 1, length);
            Swap(array, i, index);
        }
    }

    private static void Swap(int[] array, int i, int index)
    {
        int temp = array[i];
        array[i] = array[index];
        array[index] = temp;
    }
}