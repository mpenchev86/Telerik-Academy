/*
Problem 14.* Print the ASCII Table
    • Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints 
      the entire ASCII table of characters on the console (characters from 0 to 255).

Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

Note: You may need to use for-loops (learn in Internet how).
*/

using System;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
        for (short charCounter = 0; charCounter <= 255; )
        {
            if ((charCounter >= 0 && charCounter <= 31) || (charCounter >= 127 && charCounter <= 255))
            {
                Console.WriteLine("Character #{0} is: non-printable", charCounter);
            }
            else
            {
                Console.WriteLine("Character #{0} is: {1}", charCounter, (char)charCounter);
            }
            charCounter++;
        }
    }
}
