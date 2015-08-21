/*
Problem 1. Sum of 3 Numbers
    • Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;
using System.Threading;
using System.Globalization;

class SumOf3Numbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program prints to the console the sum of three real numbers entered" + "\n" + "by the user.");
        double realNum1;
        double realNum2;
        double realNum3;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid first real number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out realNum1);
        } while (parseCheck == false);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid second real number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out realNum2);
        } while (parseCheck == false);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid third real number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out realNum3);
        } while (parseCheck == false);
        double x = realNum1 + realNum2 + realNum3;
        Console.WriteLine("The sum of the three real numbers you entered is: {0}", x);
    }
}