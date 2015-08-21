/*
Problem 10. Point Inside a Circle & Outside of a Rectangle
    • Write an expression that checks for given point (x, y) if it is within the circle  K({1, 1}, 1.5)  and out of the 
      rectangle  R(top=1, left=-1, width=6, height=2) .
 */

using System;

class PointInCircleOutRectangle
{
    static void Main()   // This program does not produce separate results for the two conditions (inside circle and outside rectangle) but only deals with whether they are both met at the same time, as the examples suggest.
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
        Console.WriteLine("The point is {0}both inside the circle and outside of the rectangle.", (y > 1) && ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2.25) ? "" : "NOT "); // 'y' cannot be <=1 because then even if the point is inside the circle, it would be inside the rectangle too. The coordinates and the radius always form a right triangle. We use the Pythagorean Theorem: x^2 + y^2 = r^2.
    }
}
