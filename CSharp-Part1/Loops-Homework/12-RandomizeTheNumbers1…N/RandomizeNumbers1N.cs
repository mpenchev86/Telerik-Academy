/*
Problem 12.* Randomize the Numbers 1…N
    • Write a program that enters in integer  n  and prints the numbers  1, 2, …, n  in random order.
Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need 
to use arrays.
*/

using System;

class RandomizeNumbers1N
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer 'n': ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Randomized numbers: ");

        Random j = new Random();            // 'j' will generate the random numbers between 1 and n.
        int[] usedNums = new int[n];        // This array is empty. It gets gradually filled with numbers that have been already printed. It has as much elements as there are numbers from 1 to n.
        int indexFree = 0;                  // This index indicates the first free position in 'usedNums' array and that's why it starts from 0. 
        
        while (indexFree < n)               // The last position to be filled should be n-1. This loop stops when all positions in 'usedNums' are filled.
        {
            int randomNum = j.Next(1, n + 1);
            for (int i = 0; i < indexFree + 1; i++)             // The nested for loop iterates through all occupied positions in 'usedNums'.
            {                                                   
                if (usedNums[i] == randomNum)                   
                {
                    break;
                }
                else if (i == indexFree)                        // if the current random number is not there, it adds 'randomNum' -->
                {                                               // --> to the first free position - indexFree.
                    usedNums[indexFree] = randomNum;
                    Console.Write("{0} ", randomNum);           // The unique number is printed, indexFree gets to the nex position -->
                    indexFree++;                                // --> and the loop breaks so that a new random number is generated.
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}