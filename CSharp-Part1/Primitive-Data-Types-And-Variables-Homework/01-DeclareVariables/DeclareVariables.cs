/*
Problem 1. Declare Variables
    • Declare five variables choosing for each of them the most appropriate of the types  byte, sbyte, short, ushort, 
      int, uint, long, ulong  to represent the following values:  52130, -115, 4825932, 97, -10000 .
    • Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstValue = 52130;
        sbyte secondValue = -115;
        double thirdValue = 4825932;
        sbyte fourthValue = 97;
        short fifthValue = -10000;
        thirdValue = 9.5 % 2.1;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", firstValue, secondValue, thirdValue, fourthValue, fifthValue); //Added only so that the Editor doesn't complain about unused variables.
    }
}
