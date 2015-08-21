/*
Problem 4. Multiplication Sign
    • Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
        ◦ Use a sequence of  if  operators.
*/

using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a;
        double b;
        double c;
        bool parseCheck = false;
        string minusSign = "The sign of the product of the real numbers is -.";
        string plusSign = "The sign of the product of the real numbers is +.";
        string zeroSign = "The sign of the product of the real numbers is 0.";

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
        
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(zeroSign);
        }
        else 
        {
            if (a < 0)
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine(minusSign);
                    }
                    else
                    {
                        Console.WriteLine(plusSign);
                    }
                }
                else
                {
                    if (c < 0)
                    {
                        Console.WriteLine(plusSign);
                    }
                    else
                    {
                        Console.WriteLine(minusSign);
                    }
                }
            }
            else
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine(plusSign);
                    }
                    else
                    {
                        Console.WriteLine(minusSign);
                    }
                }
                else
                {
                    if (c < 0)
                    {
                        Console.WriteLine(minusSign);
                    }
                    else
                    {
                        Console.WriteLine(plusSign);
                    }
                }
            }
            
        }
    }
}
