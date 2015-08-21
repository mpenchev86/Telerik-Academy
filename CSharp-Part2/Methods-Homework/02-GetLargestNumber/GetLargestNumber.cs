/*
Problem 2. Get largest number
    • Write a method  GetMax()  with two parameters that returns the larger of two integers.
    • Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .
*/

using System;
class GetLargestNumber
{
    static void Main(string[] args)
    {
        int[] array = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter integer #{0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int result = GetMax(array[0], array[1]);
        if (result > array[2])
        {
            Console.WriteLine(result + " is the largest of the three.");
        }
        else
        {
            Console.WriteLine(array[2] + " is the largest of the three.");
        }
    }

    private static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
