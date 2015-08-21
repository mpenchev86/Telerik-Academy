/*
Problem 4. Triangle surface
    • Write methods that calculate the surface of a triangle by given: 
        ◦ Side and an altitude to it;
        ◦ Three sides;
        ◦ Two sides and an angle between them;
    • Use  System.Math .
*/

using System;

class TriangleSurface
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose what parameters to use to calculate the surface of a triangle:"
            + "\n" + "1 - Side and an altitude to it"
            + "\n" + "2 - Three sides"
            + "\n" + "3 - Two sides and an angle between them");
        int choise = int.Parse(Console.ReadLine());

        decimal surface = 0;

        switch (choise)
        {
            case 1:
            Console.Write("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude: ");
            double altitude = double.Parse(Console.ReadLine());

            surface = SideAndAltitude(side, altitude);
            break;
            case 2:
            Console.Write("Enter side1: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter side2: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter side3: ");
            double side3 = double.Parse(Console.ReadLine());

            surface = ThreeSides(side1, side2, side3);
            break;
            case 3:
            Console.Write("Enter side1: ");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter side2: ");
            side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter side1: ");
            double angle = double.Parse(Console.ReadLine());

            surface = TwoSidesAndAngle(side1, side2, angle);
            break;
        }

        Console.WriteLine("Surfase is: {0}", surface);
    }

    private static decimal SideAndAltitude(double side, double altitude)
    {
        return (decimal)(side * altitude / 2);
    }

    private static decimal ThreeSides(double side1, double side2, double side3)
    {
        double p = (side1 + side2 + side3) / 2;
        return (decimal)Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));                             // Heron's Formula
    }

    private static decimal TwoSidesAndAngle(double side1, double side2, double angle)
    {
        return (decimal)((side1 * side2 * Math.Sin(angle)) / 2);
    }
}