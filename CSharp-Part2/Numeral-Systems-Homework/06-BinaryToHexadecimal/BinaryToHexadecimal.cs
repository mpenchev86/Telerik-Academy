/*
Problem 6. Binary to hexadecimal
	• Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

using System;
using System.Text;

class BinaryToHexadecimal
{
	static void Main(string[] args)
	{
		Console.Write("Enter binary number: ");
		char[] input = Console.ReadLine().ToUpperInvariant().ToCharArray();
		
		Array.Reverse(input);
		string hexNumber = new string(input);

		Console.Write("Hexadecimal representation: 0x");

		string result = string.Empty;
		string temp = string.Empty;
		for (int i = 0; i < hexNumber.Length; i++)
		{
			if (temp.Length < 4)
			{
				temp += hexNumber[i];
				if (i == hexNumber.Length - 1)
				{
					for (int j = 0; j < 4 - temp.Length; j++)
					{
						temp += "0";
					}
				}
				else
				{
					continue;
				}
			}

			char hexDigit = new char{};
			switch (temp)
			{
				case "0000": hexDigit = '0'; break;
				case "1000": hexDigit = '1'; break;
				case "0100": hexDigit = '2'; break;
				case "1100": hexDigit = '3'; break;
				case "0010": hexDigit = '4'; break;
				case "1010": hexDigit = '5'; break;
				case "0110": hexDigit = '6'; break;
				case "1110": hexDigit = '7'; break;
				case "0001": hexDigit = '8'; break;
				case "1001": hexDigit = '9'; break;
				case "0101": hexDigit = 'A'; break;
				case "1101": hexDigit = 'B'; break;
				case "0011": hexDigit = 'C'; break;
				case "1011": hexDigit = 'D'; break;
				case "0111": hexDigit = 'E'; break;
				case "1111": hexDigit = 'F'; break;
			}

			result += hexDigit;
			temp = string.Empty;
			temp += hexNumber[i];
		}

		for (int i = 0; i < result.Length; i++)
		{
			Console.Write(result[result.Length - 1 - i]);
		}
		Console.WriteLine();
	}
}