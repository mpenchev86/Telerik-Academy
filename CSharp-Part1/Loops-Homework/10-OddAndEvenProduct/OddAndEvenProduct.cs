/*
Problem 10. Odd and Even Product
	• You are given  n  integers (given in a single line, separated by a space).
	• Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
	• Elements are counted from  1  to  n , so the first element is odd, the second is even, etc.
*/

using System;
using System.Numerics;

class OddAndEvenProduct
{
	static void Main(string[] args)
	{
		Console.Write("Enter a number 'n' (number of elements): ");
		uint n = uint.Parse(Console.ReadLine());

		Console.Write("Enter integers: ");
		string[] substrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		int[] inputNums = new int[n];
		BigInteger oddProduct = 1;
		BigInteger evenProduct = 1;

		for (int i = 0; i < n; i++)
		{
			inputNums[i] = int.Parse(substrings[i]);
			if (i % 2 != 0)
			{
				evenProduct *= inputNums[i];
			}
			else
			{
				oddProduct *= inputNums[i];
			}
		}

		if (evenProduct == oddProduct)
		{
			Console.WriteLine("Yes");	 
		}
		else
		{
			Console.WriteLine("No");
			Console.WriteLine("Odd product: {0}", oddProduct);
			Console.WriteLine("Even product: {0}", evenProduct);
		}
	}
}