/*
Problem 1. Decimal to binary
    • Write a program to convert decimal numbers to their binary representation.
*/

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Enter decimal number: ");
        string input = Console.ReadLine();
        char[] number = input.ToCharArray();

        char[] binaryNum = OneSystemToAnyOther.ToBaseD(number, 2);
        Console.Write("Binary representation: ");
        OneSystemToAnyOther.PrintNumber(binaryNum);
    }
}