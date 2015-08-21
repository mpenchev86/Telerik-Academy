/*
Problem 14. Decimal to Binary Number
    • Using loops write a program that converts an integer number to its binary representation.
    • The input is entered as long. The output should be a variable of type string.
    • Do not use the built-in .NET functionality.
*/

using System;

class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number of type long: ");
        long decimalNum = long.Parse(Console.ReadLine());

        long tempDecimal = decimalNum;
        string binaryNum = "";
        for (int i = 0; i < 64; i++)
        {
            if (Math.Pow(2, 63 - i) <= tempDecimal)
            {
                binaryNum += "1";
                tempDecimal -= (long)Math.Pow(2, 63 - i);
            }
            else
            {
                if (tempDecimal == decimalNum)
                {
                    if (i == 63)
                    {
                        binaryNum += "0";
                    }
                    continue;
                }
                else
                {
                    binaryNum += "0";
                }
            }
        }
        Console.WriteLine(binaryNum);
    }
}