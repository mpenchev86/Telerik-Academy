/*
Problem 11.* Numbers in Interval Dividable by Given Number
    • Write a program that reads two positive integer numbers and prints how many numbers  p  exist between them such that the remainder of 
      the division by  5  is  0 .
*/

using System;

class NumsIntervalDividableByGivenNum
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program reads two positive integer numbers and prints how many numbers"
            + "\n" + "p  exist between them such that the remainder of the division by  5  is  0 ." + "\n");
        int biggerNum;
        int smallerNum;
        int bufferBigger;
        int p = 0;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid first positive integer number ( > 0): ");
            parseCheck = int.TryParse(Console.ReadLine(), out biggerNum);
        } while (!parseCheck || biggerNum < 1);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid second positive integer number ( > 0): ");
            parseCheck = int.TryParse(Console.ReadLine(), out smallerNum);
        } while (!parseCheck || smallerNum < 1);

        if (smallerNum > biggerNum)   // We check which is bigger and assign it to the appropriate variable.
        {
            bufferBigger = smallerNum;
            smallerNum = biggerNum;
            biggerNum = bufferBigger;
        }

        for (int i = smallerNum; i <= biggerNum; i++)
        {
            if (i % 5 == 0)
            {
                p++;  
            }
        }
        Console.WriteLine("The numbers between {0} and {1} that have remainder 0 after division" 
            + "\n" + "by  5 are: {2}", smallerNum, biggerNum, p);
    }
}