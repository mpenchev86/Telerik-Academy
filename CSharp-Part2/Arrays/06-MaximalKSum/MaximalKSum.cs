/*
Problem 6. Maximal K sum
    • Write a program that reads two integer numbers  N  and  K  and an array of  N  elements from the console.
    • Find in the array those  K  elements that have maximal sum.
*/

using System;

class MaximalKSum
{
    static void Main(string[] args)
    {
                                                        /*------Initializing original array-----*/
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] arrayInput = new int[N];

        for (int i = 0; i < N; i++)
        {
            arrayInput[i] = int.Parse(Console.ReadLine());
        }
                                                        /*--------Copying and Sorting the elements in another array--------*/
        int[] arrayCopy = new int[N];
        Array.Copy(arrayInput, arrayCopy, N);
        Array.Sort(arrayCopy);
                                            
        int[] usedIndexes = new int[K];             // This array keeps the indexes of the biggest numbers in the original array
        int usedCount = 0;                          // This variable points to the next unused position in the 'usedIndexes' array

        for (int i = 0; i < K; i++)                 
        {
            usedIndexes[i] = -1;                    // We fill the indexes array with values out of range, so that we can use it for comparison of used indexes in the block below.
        }


        for (int i = N - K; i < N; i++)             // We iterate through the last K elements in 'arrayCopy', which is sorted in ascending order. Therefore, they have the maximum sum.
        {
            for (int j = 0; j < N; j++)             // We compare them with all the elements of the original array.
            {
                if (arrayInput[j] == arrayCopy[i])  
                {
                    bool isUsed = false;
                    for (int m = 0; m < K; m++)
                    {
                        if (j == usedIndexes[m])    // If there are equal elements from the two arrays, we check if the index of the element from the original array is already used (in case there are several equal numbers in the sum, they would have different indexes).
                        {
                            isUsed = true;
                            break;
                        }
                    }
                    if (isUsed)                     // If it is used, we dont use that index and element
                    {
                        continue;
                    }
                    else                            // If it is not used, we store it in the indexes array (and move to the next position in it)
                    {
                        usedIndexes[usedCount] = j; 
                        usedCount++;
                    }
                    break;
                }
            }
        }

        Console.WriteLine("The K elements that have maximal sum are: ");
        for (int i = 0; i < K; i++)                     // When all indexes from the original array are gathered, We print them and their corresponding value.
        {
            Console.WriteLine("index #{0}: {1}", usedIndexes[i], arrayInput[usedIndexes[i]]); 
        }

    }
}