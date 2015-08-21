/*
Problem 17.* Calculate GCD
    • Write a program that calculates the greatest common divisor (GCD) of given two integers  a  and  b .
    • Use the Euclidean algorithm (find it in Internet).
*/

using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number b: ");
        int b = int.Parse(Console.ReadLine());

        int dividend = a;
        int divisor = b;
        int remainder = -1;

        while (remainder != 0)
        {
            remainder = dividend % divisor;
            dividend = divisor;
            divisor = remainder;
        }

        Console.WriteLine("The greatest common divisor is: {0}", dividend);
    }
}