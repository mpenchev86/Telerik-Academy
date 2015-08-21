/*
Problem 12. Extract Bit from Integer
    • Write an expression that extracts from given integer  n  the value of given bit at index  p .
*/

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int n;
        int p;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter valid integer: ");
            parseCheck = int.TryParse(Console.ReadLine(), out n);
        } while (parseCheck == false);
        parseCheck = false;
        do
        {
            Console.Write("Enter valid bit index: ");
            parseCheck = int.TryParse(Console.ReadLine(), out p);
            if (p < 0 || p > 31)
            {
                Console.WriteLine("The specified bit index is out of the range for integer variables.");
            }
        } while (parseCheck == false || p < 0 || p > 31);

        int mask = 1 << p;     //Gives 'mask' one bit with value 1 at position #p and the rest are all 0.
        int bitZeroOrOne = Math.Abs((n & mask) >> p);    // Method 'Math.Abs()' is used in case 'n' is negative and bit #31 is occupied for the '-' sign (with value 1). Without 'Math.Abs()', the #31 bit would always return as -1 for negative integers, instead of 1.
        Console.WriteLine("The value of bit #{0} in {1} is: {2}", p, n, bitZeroOrOne);
        Console.WriteLine("Binary representation of {0}: {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}