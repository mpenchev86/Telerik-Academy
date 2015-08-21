/*
Problem 1. Odd or Even Integers
    • Write an expression that checks if given integer is odd or even.
*/

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int inputNumber;
        bool parseCheck = false;
        do                 //  This loop checks if the user had typed a valid integer number. If not, it asks for one again.
        {
            Console.Write("Enter a valid integer: ");
            parseCheck = int.TryParse(Console.ReadLine(), out inputNumber);
        } while (parseCheck == false);
        Console.WriteLine("The number you entered is {0}", inputNumber % 2 == 1 ? "ODD" : "EVEN");
    }
}