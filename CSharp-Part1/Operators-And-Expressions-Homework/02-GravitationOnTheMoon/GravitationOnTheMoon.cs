/*
Problem 2. Gravitation on the Moon
    • The gravitational field of the Moon is approximately  17%  of that on the Earth.
    • Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        decimal weightEarth;       //  Decimal is used for better accuracy when calculating percentage values.
        bool parseCheck = false;
        do        //  This loop checks if the user had typed valid weight.
        {                                                                            
            Console.Write("Enter your weight in kg: ");
            parseCheck = decimal.TryParse(Console.ReadLine(), out weightEarth);         
        } while (parseCheck == false);                    
        Console.WriteLine("Your weight on the Moon would be: {0}kg", weightEarth * 17 / 100);
    }
}