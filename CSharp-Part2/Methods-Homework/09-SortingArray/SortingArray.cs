/*
Problem 9. Sorting array
	• Write a method that return the maximal element in a portion of array of integers starting at given index.
	• Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Linq;

class SortingArray
{
	static void Main(string[] args)
	{
		Console.Write("Enter array: ");
		int[] array = Console.ReadLine()
			.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToArray();

		Console.Write("Enter starting index: ");
		int index = int.Parse(Console.ReadLine());

		SortArray(array);
	}

	private static void SortArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] == FindMax(array, i))
				{
					int temp = array[i];
					array[i] = array[j];
					array[j] = temp;
				}
			}
			if (i != array.Length - 1)
			{
				Console.Write("{0}, ", array[i]);               // Descending order
				continue;
			}
			Console.WriteLine(array[i]);
		}
	}

	private static int FindMax(int[] array, int index)
	{
		int tempMax = int.MinValue;
		for (int i = index; i < array.Length; i++)
		{
			if (array[i] > tempMax)
			{
				tempMax = array[i];
			}
		}
		return tempMax;
	}
}