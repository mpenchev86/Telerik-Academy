/*
Problem 3. Divide by 7 and 5
    • Write a Boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  at the same time.
*/

using System;

class DivideBy7and5
{
    static void Main()
    {
        int dividendInt;
        bool parseCheck = false;
        do                 //  This loop checks if the user had typed a valid integer number. If not, it asks for one again.
        {
            Console.Write("Enter a valid integer: ");
            parseCheck = int.TryParse(Console.ReadLine(), out dividendInt);
        } while (parseCheck == false);
        bool canDivideBy7and5 = dividendInt % 7 == 0 && dividendInt % 5 == 0 && dividendInt != 0;
        Console.WriteLine("The number you entered can {0}be divided without remainder by 7 and 5 at the same time.", canDivideBy7and5 ? "" : "not ");
    }
}