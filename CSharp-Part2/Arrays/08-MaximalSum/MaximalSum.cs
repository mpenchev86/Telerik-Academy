/*
Problem 8. Maximal sum
    • Write a program that finds the sequence of maximal sum in given array.
    • Can you do it with only one loop (with single scan through the elements of the array)? 
*/

using System;

class MaximalSum
{
    static void Main(string[] args)
    {
                                                        /*------ Array Initialization ------*/
        Console.Write("Enter array: ");
        string[] arrayString = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
        int[] arrayNumbers = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayNumbers[i] = int.Parse(arrayString[i]);
        }

        int maxSum = int.MinValue;                  // This is the maximal sequence sum found so far.
        int maxStart = -1;                          // The start index of 'maxSum'
        int maxEnd = -1;                            // The end index of 'maxSum'

        int tempSum = int.MinValue;                 // This is a temporary sequence sum. It is being compared to 0 and 'maxSum'
        int tempStart = -1;                         // The start index of 'tempSum'
        int tempEnd = -1;                           // The end index of 'tempSum'
            
                                                        /*------- Finding Max Sum Sequence With One Loop -------*/
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            if (arrayNumbers[i] <= 0)                       // There are two main cases - when the next number is not positive, and when it is.
            {
                if (arrayNumbers[i] > maxSum)               // If a negative number is bigger that the maximal sum at the moment, 'maxSum' is assigned that negative number.
                {
                    maxSum = arrayNumbers[i];
                    maxStart = maxEnd = i;                  // The indices are the same, since there's only one number in the sequence
                    tempSum = arrayNumbers[i];              // 'tempSum' is also assigned that value, otherwise in a next iteration arrayNumbers[i] may not be > maxSum and then 'tempSum += arrayNumbers[i]' leads to overflow of int.
                    tempStart = tempEnd = i;
                    continue;
                }

                tempSum += arrayNumbers[i];
                tempEnd = i;
            }
            else                                            // When the next number is positive
            {
                if (tempSum <= 0)                           // 'tempSum <= 0' means that the temporary sequence has no value to a possible future maximal sum
                {
                    tempSum = arrayNumbers[i];              // in such case, 'tempSum' is renewed with the current positive number
                    tempStart = i;                          // Its indices too.
                    tempEnd = i;
                    if (tempSum > maxSum)                   // If the current positive number is even bigger that the current maximal sum, 'maxSum' shifts to it.
                    {
                        maxSum = tempSum;
                        maxStart = i;                       // The indices shift too
                        maxEnd = i;
                    }
                }
                else                                        // If tempSum > 0, the temporary sequence is concatenated with the current positive number
                {
                    tempSum = tempSum + arrayNumbers[i];
                    tempEnd = i;

                    if (tempSum > maxSum)                   // If the now increased 'tempSum' is bigger than 'maxSum', 'maxSum' shifts to it.
                    {
                        maxSum = tempSum;
                        maxStart = tempStart;               // The indices shift too
                        maxEnd = tempEnd;
                    }
                }
            }
        }
                                                        /*------- Printing -------*/
        Console.Write("The sequence of maximal sum is: ");
        for (int i = maxStart; i <= maxEnd; i++)
        {
            if (i != maxEnd)
            {
                Console.Write("{0}, ", arrayNumbers[i]);
                continue;
            }
            Console.WriteLine(arrayNumbers[i]);
            Console.WriteLine("Sum: {0}", maxSum);
        }
    }
}