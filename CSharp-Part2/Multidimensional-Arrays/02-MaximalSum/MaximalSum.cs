/*
Problem 2. Maximal sum
	• Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  that has maximal sum of its 
	  elements.
*/

using System;
using System.Linq;
using System.Collections.Generic;

class MaximalSum
{
	static void Main(string[] args)
	{
		Console.Write("Enter number of matrix rows (>=3): ");
		int N = int.Parse(Console.ReadLine());
		Console.Write("Enter number of matrix colums (>=3): ");
		int M = int.Parse(Console.ReadLine());
		var matrix = new int[N,M];

		for (int i = 0; i < N; i++)
		{
			Console.WriteLine("Enter numbers in row #{0}:", i);
			string[] line = Console.ReadLine().Split(new string[] { " ", ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);
			for (int j = 0; j < M; j++)
			{
				matrix[i, j] = Convert.ToInt32(line[j]);
			}
		}

		int Sum = 0;
		int maxRow = -1;
		int maxCol = -1;
		for (int i = 0; i < N - 2; i++)
		{
			for (int j = 0; j < M - 2; j++)
			{
				int currentSum = 0;
				for (int k = 0; k < 3; k++)
				{
					for (int m = 0; m < 3; m++)
					{
						currentSum += matrix[i, j];
					}
				}
				if (currentSum > Sum)
				{
					Sum = currentSum;
					maxRow = i;
					maxCol = j;
				}
			}
		}

		Console.WriteLine("square  3 x 3  with maximal sum starts at element[{0}, {1}]", maxRow, maxCol);
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Console.Write("{0,6}", matrix[maxRow + i, maxCol + j]);
			}
			Console.WriteLine();
		}
	}
}