/*
Problem 4. Rectangles
    • Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/

using System;

class Rectangles
{
    static void Main()
    {
        double rectangleWidth;
        double rectangleHeight;

        bool parseCheck = false;
        do               //Checks the validiti of the width variable.
        {
            Console.Write("Enter a valid width for the rectangle: ");
            parseCheck = double.TryParse(Console.ReadLine(), out rectangleWidth);
        } while (parseCheck == false);

        parseCheck = false;     // Resets the flag for the next loop.
        do               //Checks the validiti of the height variable.
        {
            Console.Write("Enter a valid height for the rectangle: ");
            parseCheck = double.TryParse(Console.ReadLine(), out rectangleHeight);
        } while (parseCheck == false);

        double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeight);
        double rectangleArea = rectangleWidth * rectangleHeight;
        Console.WriteLine("The rectangle's perimeter is: {0}" +"\n"+ "The rectangle's area is: {1}", rectanglePerimeter, rectangleArea);
    }
}