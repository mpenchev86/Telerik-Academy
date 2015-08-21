/*
Problem 3. Variable in Hexadecimal Format
    • Declare an integer variable and assign it with the value  254  in hexadecimal format ( 0x## ).
    • Use Windows Calculator to find its hexadecimal representation.
    • Print the variable and ensure that the result is  254 .
*/

using System;

class HexadecimalFormat
{
    static void Main()
    {
        int hexadecimalVar = 0xFE;                 // Conversion from 0xFE to 254 goes as follows: E * 16^0 + F * 16^1 = 14 * 1 + 15 * 16 = 254
        Console.WriteLine(hexadecimalVar);
    }
}
