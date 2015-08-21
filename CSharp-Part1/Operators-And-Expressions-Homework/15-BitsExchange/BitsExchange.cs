/*
Problem 15.* Bits Exchange
    • Write a program that exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer.
 */

using System;

class BitsExchange
{
    static void Main()
    {
        uint n;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter valid integer: ");
            parseCheck = uint.TryParse(Console.ReadLine(), out n);
        } while (parseCheck == false);
        Console.WriteLine("Binary representation for the original 'n' is:     {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        uint carryBits_3_4_5 = 7 << 3;      // 7 looks like ...00000111. So it can serve for a mask for three consecutive bits. If we shift it to the left with 3, the '1' bit will be in position #3, #4 and #5.
        carryBits_3_4_5 = n & carryBits_3_4_5;   // The new value of the mask is loaded with bits #3, #4 and #5 from 'n'.
        carryBits_3_4_5 = carryBits_3_4_5 << 21;  // Now we shift them to positions #24, #25 and #26, ready to assign them to the corresponding bits in the original 'n'.
        Console.WriteLine("Binary representation for 'carryBits_3_4_5' is:    {0}", Convert.ToString(carryBits_3_4_5, 2).PadLeft(32, '0'));

        uint carryBits_24_25_26 = 7 << 24;    // Analogous operation to the one with 'carryBits_3_4_5'.
        carryBits_24_25_26 = n & carryBits_24_25_26;
        carryBits_24_25_26 = carryBits_24_25_26 >> 21;  // This time the loaded bits should be shifted in the opposite direction, to positions #3, #4 and #5, ready to take the place of those we shifted with 'carryBits_3_4_5'.
        Console.WriteLine("Binary representation for 'carryBits_24_25_26' is: {0}", Convert.ToString(carryBits_24_25_26, 2).PadLeft(32, '0'));

        uint maskN = 7 << 24;
        n = n & ~maskN;                // Here, 'maskN' serves to convert positions #24, #25 and #26 to '0', so that they are "vacant".
        n = n | carryBits_3_4_5;       // Now 'n' receives the bits shifted from positions #3, #4 and #5 to positions #24, #25 and #26.
        maskN = 7 << 3;
        n = n & ~maskN;                // Here, 'maskN' serves to convert positions #3, #4 and #5 to '0', so that they are "vacant".
        n = n | carryBits_24_25_26;    // Now 'n' receives the bits shifted from positions #24, #25 and #26 to positions #3, #4 and #5.
        
        Console.WriteLine("Binary representation for the modified 'n' is:     {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}