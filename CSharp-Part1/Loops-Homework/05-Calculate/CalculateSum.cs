/*
Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
    • Write a program that, for a given two integer numbers  n  and  x , calculates the sum  S = 1 + 1!/x + 2!/x2 + … + n!/x^n .
    • Use only one loop. Print the result with  5  digits after the decimal point.
*/

using System;

class CalculateSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer 'n': ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter an integer 'x': ");
        int x = int.Parse(Console.ReadLine());
        double s = 1;
        double nextAdd = 1;
        for (int i = 1; i < n+1; i++)
        {
            nextAdd = nextAdd * i / x;
            s += nextAdd;
        }
        Console.WriteLine("The sum 'S = 1 + 1!/x + 2!/x2 + … + n!/x^n' is: {0:F5}", s);
    }
}