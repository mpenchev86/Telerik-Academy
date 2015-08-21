/*
Problem 8. Number as array
	• Write a method that adds two positive integer numbers represented as arrays of digits (each array element  arr[i]  contains a digit; the last 
	  digit is kept in  arr[0] ).
	• Each of the numbers that will be added could have up to  10 000  digits.
*/

using System;
using System.Text;

class NumberAsArray
{
	static void Main(string[] args)
	{

		Console.WriteLine("Enter first positive integer number: ");
		char[] array1 = ReadNumber().ToString().ToCharArray();

		ReverseDigits(array1);

		Console.WriteLine("Enter second positive integer number: ");
		char[] array2 = ReadNumber().ToString().ToCharArray();
		
		ReverseDigits(array2);

		Console.WriteLine("Result of addition:");

		if (array1.Length >= array2.Length)
		{
			Console.WriteLine(AddArrays(array1, array2));
		}
		else
		{
			Console.WriteLine(AddArrays(array2, array1));
		}
	}

	private static StringBuilder ReadNumber()
	{
		StringBuilder arr = new StringBuilder();
		while (true)
		{
			char next = Convert.ToChar(Console.Read());
			if (next == '\n')
			{
				arr.Remove(arr.Length - 1, 1);
				break;
			}
			arr.Append(next);
		}
		return arr;
	}

	private static string AddArrays(char[] array1, char[] array2)
	{
		StringBuilder tempResult = new StringBuilder();
		int temp = 0;
		for (int i = 0; i < array2.Length; i++)
		{
			tempResult.Insert(0, (temp + ((int)array1[i] - 48) + ((int)array2[i] - 48)) % 10);
			if ((temp + ((int)array1[i] - 48) + ((int)array2[i] - 48)) / 10 > 0)
			{
				temp = (temp + ((int)array1[i] - 48) + ((int)array2[i] - 48)) / 10;
			}
			else
			{
				temp = 0;
			}
		}

		for (int i = array2.Length; i < array1.Length; i++)
		{
			tempResult.Insert(0, (temp + ((int)array1[i] - 48)) % 10);
			if ((temp + ((int)array1[i] - 48)) / 10 > 0)
			{
				temp = (temp + ((int)array1[i] - 48)) / 10;
			}
			else
			{
				temp = 0;
			}
		}

		if (temp != 0)
		{
			tempResult.Insert(0, temp);
		}
		
		string result = tempResult.ToString();
		return result;
	}

	private static void ReverseDigits(char[] array)
	{
		for (int i = 0; i < array.Length / 2; i++)
		{
			char temp = array[i];
			array[i] = array[array.Length - 1 - i];
			array[array.Length - 1 - i] = temp;
		}
	}
}