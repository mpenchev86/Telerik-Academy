/*
Problem 6. Four-Digit Number
    • Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        ◦ Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ).
        ◦ Prints on the console the number in reversed order:  dcba  (in our example  1102 ).
        ◦ Puts the last digit in the first position:  dabc  (in our example  1201 ).
        ◦ Exchanges the second and the third digits:  acbd  (in our example  2101 ).
The number has always exactly 4 digits and cannot start with 0.
 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        int inputNumber;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid integer: ");
            parseCheck = int.TryParse(Console.ReadLine(), out inputNumber);
        } while (parseCheck == false || inputNumber < 1000 || inputNumber > 9999);

        int firstDigit = inputNumber / 1000;
        int secondDigit = inputNumber / 100 % 10;
        int thridDigit = inputNumber / 10 % 10;
        int fourthDigit = inputNumber % 10;

        Console.WriteLine("The sum of the digits of {0} is {1}", inputNumber, firstDigit + secondDigit + thridDigit + fourthDigit);
        Console.WriteLine("The number in reversed order looks like {0}{1}{2}{3}", fourthDigit, thridDigit, secondDigit, firstDigit);
        Console.WriteLine("The number with the last digit in the first position is {0}{1}", fourthDigit, inputNumber / 10);
        Console.WriteLine("The number with exchanged second and third digits is {0}{2}{1}{3}", firstDigit, secondDigit, thridDigit, fourthDigit);

    }
}