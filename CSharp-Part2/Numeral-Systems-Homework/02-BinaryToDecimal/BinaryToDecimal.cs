/*
Problem 2. Binary to decimal
    • Write a program to convert binary numbers to their decimal representation.
*/

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();
        char[] number = input.ToCharArray();
        Array.Reverse(number);

        char[] decimalNum = OneSystemToAnyOther.ToDecimal(number, 2);
        OneSystemToAnyOther.PrintNumber(decimalNum);
    }
}