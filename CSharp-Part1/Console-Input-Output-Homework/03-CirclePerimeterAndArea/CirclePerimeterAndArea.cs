/*
Problem 3. Circle Perimeter and Area
    • Write a program that reads the radius  r  of a circle and prints its perimeter and area formatted with  2  digits after the decimal point.
*/

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program reads the radius  r  of a circle and prints its perimeter and" +"\n"+ "area formatted with  2  digits after the decimal point.");
        double circleRadius;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter the radius of the circle: ");
            parseCheck = double.TryParse(Console.ReadLine(), out circleRadius);
        } while (!parseCheck);
        Console.WriteLine("Circle's perimeter is: {0:0.00}", 2 * Math.PI * circleRadius);
        Console.WriteLine("Circle's area is: {0:0.00}", Math.PI * circleRadius * circleRadius);

    }
}
