/*
Problem 5. Maximal increasing sequence
    • Write a program that finds the maximal increasing sequence in an array.
*/

using System;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
                                                            /*----------Initialization of the sequence in an array----------*/
        Console.Write("Enter array length: ");
        int arrLenght = int.Parse(Console.ReadLine());
        Console.Write("Enter array: ");
        int[] arrayInput = new int[arrLenght];
        for (int i = 0; i < arrLenght; i++)
        {
            arrayInput[i] = int.Parse(Console.ReadLine());
        }

        int maxSequence = 1;                        // The final value of maximal increasing sequence of elements.
        int tempMax = 1;                            // Temporary variable to store last maximal sequence value.
        int elementValue = 0;                       // Stores the last (biggest) element in the temporary maximal sequence.

                                                            /*----------Checking for sequences----------*/
        for (int i = 0; i < arrLenght - 1; i++)
        {

            if (arrayInput[i] == arrayInput[i + 1] - 1)
            {
                tempMax++;                          // It increases when one element is smaller than the next with 1.
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
            Console.Write("Maximal sequence of increasing elements: ");
            for (int i = maxSequence - 1; i > 0; i--)           // 'i' decreases so that the next element increases--->     
            {
                Console.Write(elementValue - i + ", "); 
            }
            Console.WriteLine(elementValue);                    //---> until the last number in the sequence, stored in 'elementValue'
        }
        else
        {
            Console.WriteLine("There's no sequence of increasing elements.");
        }
    }
}