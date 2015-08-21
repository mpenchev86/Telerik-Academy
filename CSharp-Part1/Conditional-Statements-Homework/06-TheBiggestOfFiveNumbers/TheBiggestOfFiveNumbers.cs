/*
Problem 6. The Biggest of Five Numbers
    • Write a program that finds the biggest of five numbers by using only five if statements.
*/

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a;
        double b;
        double c;
        double d;
        double e;
        bool parseCheck = false;
        string biggestIs = "Biggest number is: {0}";
        
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
        parseCheck = false;
        do
        {
            Console.Write("Enter third double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out c);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter fourth double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out d);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter fifth double number: ");
            parseCheck = double.TryParse(Console.ReadLine(), out e);
        } while (!parseCheck);

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(biggestIs, a);
        }
        if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(biggestIs, b);            
        }
        if (c >= a && c >= b && b >= d && b >= e)
        {
            Console.WriteLine(biggestIs, c);
        }
        if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine(biggestIs, d);
        }
        if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(biggestIs, e);
        }
    }
}
