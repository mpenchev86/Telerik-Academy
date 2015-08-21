/*
Problem 4. Maximal sequence
	• Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;
using System.Linq;

class MaximalSequence
{
	static void Main(string[] args)
	{
	                                                        /*----------Initialization of the sequence in an array----------*/
		int arrLenght = int.Parse(Console.ReadLine());
		string [] arrayInput = new string[arrLenght];       // String is used in case the elements are not numbers (since no such condition is defined in the problem).
		for (int i = 0; i < arrLenght; i++)
		{
			arrayInput[i] = Console.ReadLine();
		}

		int maxSequence = 1;                        // The final value of maximal sequence of equal elements.
		int tempMax = 1;                            // Temporary variable to store last maximal sequence value.
		string elementValue = "";                   // Stores the element repeated in the temporary maximal sequence.

															/*----------Checking for sequences----------*/
		for (int i = 0; i < arrLenght - 1; i++)
		{

			if (arrayInput[i] == arrayInput[i + 1])
			{
				tempMax++;                          // It increases when two neighbour elements are equal.
			}
			else
			{
				if (tempMax > maxSequence)          // If the sequence is broken, the temporary result is saved.
				{
					maxSequence = tempMax;
					elementValue = arrayInput[i];
				}
				tempMax = 1;                        // tempMax is reset for the next sequence.
			}
		}
															/*----------Chechs if there's any sequence at all and prints the results---------*/
		if (maxSequence > 1)
		{
			Console.Write("Maximal sequence of equal elements: ");
			for (int i = 0; i < maxSequence - 1; i++)
			{
				Console.Write(elementValue +", ");
			}
			Console.WriteLine(elementValue);
		}
		else
		{
			Console.WriteLine("There's no sequence of equal elements.");
		}

	}
}