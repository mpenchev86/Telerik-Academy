/*
Problem 4. Unicode Character
    • Declare a character variable and assign it with the symbol that has Unicode code  42  (decimal) using the  \u00XX  syntax, 
      and then print it.

Hint: first, use the Windows Calculator to find the hexadecimal representation of  42 . The output should be  * .
*/

using System;

class UnicodeCharacter
{
    static void Main()
    {
        char symbolValue = '\u002A';       // 42(decimal) equals 2A(hexadecimal), so Unicode code 42 will be assigned and represented by \u002A
        Console.WriteLine(symbolValue);
    }
}
