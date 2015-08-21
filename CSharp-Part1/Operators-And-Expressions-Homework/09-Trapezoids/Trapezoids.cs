/*
Problem 9. Trapezoids
    • Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h .
 */

using System;

class Trapezoids
{
    static void Main()
    {
        double sideA;
        double sideB;
        double heightH;
        bool parseCheck = false;

        do
        {
            Console.Write("Enter valid first trapezoid side: ");
            parseCheck = double.TryParse(Console.ReadLine(), out sideA);
        } while (parseCheck == false);
        parseCheck = false;
        do
        {
            Console.Write("Enter valid second trapezoid side: ");
            parseCheck = double.TryParse(Console.ReadLine(), out sideB);
        } while (parseCheck == false);
        parseCheck = false;
        do
        {
            Console.Write("Enter valid trapezoid height: ");
            parseCheck = double.TryParse(Console.ReadLine(), out heightH);
        } while (parseCheck == false);

        Console.WriteLine("The trapezoid's area by given parameters is: {0}", (sideA + sideB) / 2 * heightH);
    }
}