/*
Problem 3. Decimal to hexadecimal
    • Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter decimal number: ");
        string input = Console.ReadLine();
        char[] number = input.ToCharArray();

        char[] binaryNum = OneSystemToAnyOther.ToBaseD(number, 16);
        Console.Write("Hexadecimal representation: 0x");
        OneSystemToAnyOther.PrintNumber(binaryNum);
    }
}