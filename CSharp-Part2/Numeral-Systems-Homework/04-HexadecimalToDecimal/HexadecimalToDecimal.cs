/*
Problem 4. Hexadecimal to decimal
    • Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter hexadecimal number: ");
        string input = Console.ReadLine();
        char[] number = input.ToCharArray();
        Array.Reverse(number);

        char[] decimalNum = OneSystemToAnyOther.ToDecimal(number, 16);
        Console.Write("Decimal representation: ");
        OneSystemToAnyOther.PrintNumber(decimalNum);
    }
}