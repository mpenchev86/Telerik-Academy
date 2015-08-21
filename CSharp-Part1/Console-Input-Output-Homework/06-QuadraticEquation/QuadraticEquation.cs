/*
Problem 6. Quadratic Equation
    • Write a program that reads the coefficients  a ,  b  and  c  of a quadratic equation ax2 + bx + c = 0 and solves it (prints its 
      real roots).
*/

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program reads the coefficients  a ,  b  and  c  of a quadratic equation" 
            + "\n" + "ax2 + bx + c = 0 and solves it (prints its real roots)." + "\n");
        double a;
        double b;
        double c;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid first coefficient 'a': ");
            parseCheck = double.TryParse(Console.ReadLine(), out a);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid second coefficient 'b': ");
            parseCheck = double.TryParse(Console.ReadLine(), out b);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid third coefficient 'c': ");
            parseCheck = double.TryParse(Console.ReadLine(), out c);
        } while (!parseCheck);
        if (b * b - 4 * a * c < 0)
        {
            Console.WriteLine("\n" + "The quadratic equation has no real roots.");
        }
        else if (b * b - 4 * a * c > 0)
        {
            Console.WriteLine("\n" + "The real roots of the quadratic equation are: x1={0}; x2={1}",
            (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a),
            (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
        }
        else
        {
            Console.WriteLine("\n" + "The real roots of the quadratic equation are: x1=x2={0}", - b / (2 * a));
        }
    }
}