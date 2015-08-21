/*
Problem 7. Point in a Circle
    • Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .
 */

using System;

class PointInACircle
{
    static void Main()
    {
        double x;
        double y;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid x coordinate for the point: ");
            parseCheck = double.TryParse(Console.ReadLine(), out x);
        } while (parseCheck == false);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid y coordinate for the point: ");
            parseCheck = double.TryParse(Console.ReadLine(), out y);
        } while (parseCheck == false);
        Console.WriteLine("The point is {0} the circle.", x * x + y * y <= 4 ? "inside" : "outside"); // The coordinates and the radius always form a right triangle. We use the Pythagorean Theorem: a^2 + b^2 = c^2, or x^2 + y^2 = r^2.
    }
}