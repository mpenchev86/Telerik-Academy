/*
Problem 12.* Zero Subset
    • We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    • Assume that repeating the same subset several times is not a problem.
*/

using System;

class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: " + "\n");
        int[] numArray = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numArray[i] = Int32.Parse(Console.ReadLine());
        }

        int isSumZero;
        int countSubsets = 0;
        int tempNum;

        for (int i = 0; i < 5; i++)
        {
            isSumZero = numArray[0] + numArray[1] + numArray[2] + numArray[3] + numArray[4];
            if ((isSumZero -= numArray[i]) == 0)
            {
                tempNum = numArray[i];
                numArray[i] = numArray[4];
                numArray[4] = tempNum;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numArray[0], numArray[1], numArray[2], numArray[3]);
                countSubsets++;
                tempNum = numArray[i];
                numArray[i] = numArray[4];
                numArray[4] = tempNum;
            }
            for (int j = 0; j < 4; j++)
            {
                isSumZero = numArray[0] + numArray[1] + numArray[2] + numArray[3];
                if (j == i)
                {
                    continue;
                }
                if ((isSumZero -= numArray[j]) == 0)
                {
                    tempNum = numArray[j];
                    numArray[j] = numArray[3];
                    numArray[3] = tempNum;
                    Console.WriteLine("{0} + {1} + {2} = 0", numArray[0], numArray[1], numArray[2]);
                    countSubsets++;
                    tempNum = numArray[j];
                    numArray[j] = numArray[3];
                    numArray[3] = tempNum;
                }
                for (int k = 0; k < 3; k++)
                {
                    isSumZero = numArray[0] + numArray[1] + numArray[2];
                    if (k == i || k == j)
                    {
                        continue;
                    }
                    if ((isSumZero -= numArray[k]) == 0)
                    {
                        tempNum = numArray[k];
                        numArray[k] = numArray[2];
                        numArray[2] = tempNum;
                        Console.WriteLine("{0} + {1} = 0", numArray[0], numArray[1]);
                        countSubsets++;
                        tempNum = numArray[k];
                        numArray[k] = numArray[2];
                        numArray[2] = tempNum;
                    }
                }
            }
        }

        if (countSubsets == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}