/*
Problem 5. The Biggest of 3 Numbers
    • Write a program that finds the biggest of three numbers.
*/

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double firstNum;
        double secondNum;
        double thirdNum;
        bool parseCheck = false;
        string biggestIs = "The biggest of three numbers is: {0}";

        do
        {
            Console.Write("Enter first double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out firstNum);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter second double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out secondNum);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter third double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out thirdNum);
        } while (!parseCheck);

        if (firstNum >= secondNum && firstNum >= thirdNum)
        {
            Console.WriteLine(biggestIs, firstNum);
        }
        if (secondNum >= firstNum && secondNum >= thirdNum)
        {
            Console.WriteLine(biggestIs, secondNum);
        }
        if (thirdNum >= firstNum && thirdNum >= secondNum)
        {
            Console.WriteLine(biggestIs, thirdNum);
        } 
    }
}
