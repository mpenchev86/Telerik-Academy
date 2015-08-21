/*
Problem 13.* Comparing Floats
    • Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 .

Note: Two floating-point numbers  a  and  b  cannot be compared directly by  a == b  because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant  eps .
*/

using System;
using System.Threading;

class ComparingFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Console.Write("Enter first floating-point (double) number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second floating-point (double) number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        bool areEqual = Math.Abs(firstNumber - secondNumber) < 0.000001;
        Console.WriteLine("The numbers you entered are {0}.", areEqual ? "equal" : "not equal");
    }
}
