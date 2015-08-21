/*
Problem 10. Find sum in array
    • Write a program that finds in given array of integers a sequence of given sum  S  (if present).
*/

using System;

class FindSumInArray
{
    static void Main(string[] args)
    {
                                                        /*------ Initialization ------*/
        Console.Write("Enter array: ");
        string[] arrayString = Console.ReadLine().Split(new string[]{" ",","}, StringSplitOptions.RemoveEmptyEntries);
        int[] arrayNumbers = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayNumbers[i] = int.Parse(arrayString[i]);
        }
        Console.Write("Enter sequence sum S: ");
        int S = int.Parse(Console.ReadLine());
        
                                        /*------- Iterating through all elements as starting positions for the sequence -------*/
        int tempSum = 0;

        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            for (int j = i; j < arrayNumbers.Length; j++)
            {
                tempSum += arrayNumbers[j];                         // 'tempSum' starts from 0 and is added all elements after position 'i' one by one, comparing 'tempSum' with 'S' on each step
                if (tempSum == S)
                {
                    Console.Write("Sequence of sum S in the array: ");          // If the sequence is found, the loop below prints the result and breaks the inner loop
                    for (int k = i; k <= j; k++)
                    {
                        if (k != j)
                        {
                            Console.Write("{0}, ", arrayNumbers[k]);
                            continue;
                        }
                        Console.WriteLine("{0}", arrayNumbers[k]);
                    }
                    break;
                }
            }

            if (tempSum == S)                                       // If the inner loop has been 'broken', the outer loop is also redundant now, so we break it too
            {
                break;
            }
            else                                                    
            {
                if (i == arrayNumbers.Length - 1)                   // If the sequence is not found in the inner loop until the last array position 'i', we print this result and break the outer loop
                {
                    Console.WriteLine("There's no such sequence.");
                    break;
                }
                tempSum = 0;                                        // If the last position is not reached yet, 'tempSum' is reset to 0, ready to calculate the sequences on the next array position 'i'
            }
        }
    }
}