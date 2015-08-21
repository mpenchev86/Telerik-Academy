/*
Problem 13. Binary to Decimal Number
    • Using loops write a program that converts a binary integer number to its decimal form.
    • The input is entered as string. The output should be a variable of type long.
    • Do not use the built-in .NET functionality.
*/

using System;

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        string binaryNum = Console.ReadLine().PadLeft(64, '0');
        char[] binaryChar = binaryNum.ToCharArray();
        
        long decimalNum = 0;
        long powerOf2 = 1;

        for (int i = 0; i < 64; i++)
        {
            if (binaryChar[63 - i] == '1')
            {
                decimalNum += powerOf2;
            }
            powerOf2 *= 2;
        }
        Console.WriteLine("Decimal representation as long: {0}", decimalNum);
    }
}