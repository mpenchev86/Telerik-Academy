/*
Problem 11. Bitwise: Extract Bit #3
    • Using bitwise operators, write an expression for finding the value of the bit  #3  of a given unsigned integer.
    • The bits are counted from right to left, starting from bit  #0 .
    • The result of the expression should be either  1  or  0 . 
*/

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        uint givenUInt;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter valid unsigned integer: ");
            parseCheck = uint.TryParse(Console.ReadLine(), out givenUInt);
        } while (parseCheck == false);

        uint mask = 1 << 3;     //Gives 'mask' one bit with value 1 at position #3 and the rest are all 0.
        uint bitZeroOrOne = (givenUInt & mask) >> 3;    // bitwize 'and' with '1' equals the value of the other bit. Then it brings the bit in question to position #0 so that the value of 'bitZeroOrOne' could be either 0 or 1.
        Console.WriteLine("The value of bit #3 of {0} is: {1}", givenUInt, bitZeroOrOne);
    }
}