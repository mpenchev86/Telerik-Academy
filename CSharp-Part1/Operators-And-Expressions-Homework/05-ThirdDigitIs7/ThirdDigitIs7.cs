/*
Problem 5. Third Digit is 7?
    • Write an expression that checks for given integer if its third digit from right-to-left is  7 .
*/

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int inputInteger;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid integer: ");
            parseCheck = int.TryParse(Console.ReadLine(), out inputInteger);
        } while (parseCheck == false);

        bool checkIf7 = (inputInteger/100 - 7) % 10 == 0;   // Dividing 'inputInteger' by 100 cuts the last two digits. Then if the third from right-to-left was 7, now it will first. After subtracting 7 from the value that was cut, it should be divisible by 10 without remainder.
        Console.WriteLine("The third digit of {0} from right-to-left is {1}7", inputInteger, checkIf7 ? "" : "not ");
    }
}