/*
Problem 3. Min, Max, Sum and Average of N Numbers
    • Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal, the maximal number, the sum 
      and the average of all numbers (displayed with 2 digits after the decimal point).
    • The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
    • The output is like in the examples below.
*/

using System;
using System.Globalization;
using System.Threading;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("How many numbers do you want to enter?: ");
        int n = int.Parse(Console.ReadLine());
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        int sum = 0;
        double average;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < min)
            {
                min = input;
            }
            if (input > max)
            {
                max = input;
            }
            sum += input;
        }
        average = ((double)sum) / n;

        Console.WriteLine("min = {0}" + "\n" + "max = {1}" + "\n" + "sum = {2}" + "\n" + "avg = {3:0.00}", min, max, sum, average);
    }
}
