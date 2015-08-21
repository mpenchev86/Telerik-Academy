/*
Problem 15. Hexadecimal to Decimal Number
    • Using loops write a program that converts a hexadecimal integer number to its decimal form.
    • The input is entered as string. The output should be a variable of type long.
    • Do not use the built-in .NET functionality.
*/

using System;

class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a hexadecimal integer number: ");
        string decimalNum = Console.ReadLine().PadLeft(16, '0').ToUpperInvariant();
        if (decimalNum.Length > 16)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        long decimalLong = 0;
        byte powerCount = 15;
        foreach (char hexadeci in decimalNum)
        {
            switch (hexadeci)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    decimalLong += (long)char.GetNumericValue(hexadeci) * (long)Math.Pow(16, powerCount);
                    powerCount--;
                    break;
                case 'A':
                decimalLong += 10 * (long)Math.Pow(16, powerCount);
                powerCount--;
                break;
                case 'B':
                decimalLong += 11 * (long)Math.Pow(16, powerCount);
                powerCount--;
                break;
                case 'C':
                decimalLong += 12 * (long)Math.Pow(16, powerCount);
                powerCount--;
                break;
                case 'D':
                decimalLong += 13 * (long)Math.Pow(16, powerCount);
                powerCount--;
                break;
                case 'E':
                decimalLong += 14 * (long)Math.Pow(16, powerCount);
                powerCount--;
                break;
                case 'F':
                    decimalLong += 14 * (long)Math.Pow(16, powerCount);
                    powerCount--;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    return;
            }
        }
        Console.WriteLine("Decimal representation: {0}", decimalLong);
    }
}