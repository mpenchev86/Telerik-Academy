/*
Problem 1. Exchange If Greater
    • Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
      As a result print the values a and b, separated by a space.
 */

using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a;
        double b;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter first double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out a);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter second double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out b);
        } while (!parseCheck);
        
        if (a > b)
        {
            double tempNum = b;
            b = a;
            a = tempNum;
            /* 
             The code below could also be used, but due to the computational nature of floating-point numbers, a temp variable is preferable.
                    a = a - b;
                    b = b + a;
                    a = b - a;
             */
        }
        Console.WriteLine("\n" + "The values a and b are: {0} {1}", a, b);
    }
}