/*
Problem 4. Number Comparer
    • Write a program that gets two numbers from the console and prints the greater of them.
    • Try to implement this without if statements.
*/

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program gets two numbers from the console and prints the greater of them.");
        double firstNum;
        double secondNum;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter first number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out firstNum);
        } while(!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter second number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out secondNum);
        } while (!parseCheck);
        Console.WriteLine("The greater of the two numbers you entered is: {0}", (firstNum + secondNum + Math.Abs(firstNum - secondNum)) / 2);
    }
}