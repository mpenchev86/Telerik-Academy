/*
Problem 16.** Bit Exchange (Advanced)
    • Write a program that exchanges bits  {p, p+1, …, p+k-1}  with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
    • The first and the second sequence of bits may not overlap.
 */

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
                                                // ---------- Beginning of parameters input block. -----------------
        uint n;
        int p;
        int q;
        int k;

        bool parseCheck = false;
        do
        {
            Console.Write("Enter valid integer: ");
            parseCheck = uint.TryParse(Console.ReadLine(), out n);
        } while (parseCheck == false);

        parseCheck = false;
        do
        {
            do
            {
                Console.Write("Enter starting bit index p for sequenceP: ");
                parseCheck = int.TryParse(Console.ReadLine(), out p);
                if (p < 0 || p > 31)
                {
                    Console.WriteLine("The specified bit index is out of range for integer variables.");
                }
            } while (parseCheck == false || p < 0 || p > 31);
            do
            {
                Console.Write("Enter starting bit index q for sequenceQ: ");
                parseCheck = int.TryParse(Console.ReadLine(), out q);
                if (q < 0 || q > 31)
                {
                    Console.WriteLine("The specified bit index is out of range for integer variables.");
                }
            } while (parseCheck == false || q < 0 || q > 31);
            do
            {
                Console.Write("Enter length 'k' for the bit sequences: ");
                parseCheck = int.TryParse(Console.ReadLine(), out k);
                if (k < 1 || k > 16)
                {
                    Console.WriteLine("The specified length must be between 1 and 16. Try again :)");
                }
            } while (parseCheck == false || k < 1 || k > 16);
            if ((p + k - 1 >= q) && (q + k - 1 >= p) || (p + k - 1 > 31) || (q + k - 1 > 31)) 
            {
                Console.WriteLine("The specified parameters either lead to sequence overlapping or exceed" + "\n" + "the bit range allowed for uint numbers. Try again, you'll get better :)");
            }
        } while ((p == q) || ((p + k - 1 >= q) && (q + k - 1 >= p)) || (p + k - 1 > 31) || (q + k - 1 > 31));

        Console.WriteLine("Binary representation for the original 'n' is: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
                                                // ---------- End of parameters input block. --------------
                                                // ---------- Beginning of sequence-masks block. --------------
        uint sequenceP = uint.MaxValue >> (31 - (k - 1));
        sequenceP = sequenceP << p;
        sequenceP = n & sequenceP;
        if (p > q)           // This block shifts 'sequenceP' to starting position bit #q
        {
            sequenceP = sequenceP >> (p - q);
        }
        else 
        {
            sequenceP = sequenceP << (q - p);
        }
        Console.WriteLine("Binary representation for 'sequenceP' is:      {0}", Convert.ToString(sequenceP, 2).PadLeft(32, '0'));

        uint sequenceQ = uint.MaxValue >> (31 - (k - 1));
        sequenceQ = sequenceQ << q;
        sequenceQ = n & sequenceQ;
        if (q > p)           // This block shifts 'sequenceQ' to starting position bit #p
        {
            sequenceQ = sequenceQ >> (q - p);
        }
        else
        {
            sequenceQ = sequenceQ << (p - q);
        }
        Console.WriteLine("Binary representation for 'sequenceQ' is:      {0}", Convert.ToString(sequenceQ, 2).PadLeft(32, '0'));
                                                // ---------- End of sequence-masks block. --------------
                                                // ---------- Beginning of number-mask block. --------------
        uint maskN = uint.MaxValue >> 31 - (k - 1);      // Mask with '1' on all bits is shifted right so that only k bits remain '1', all others become '0'.
        maskN = maskN << q;      // maskN is now shifted q bits to align with the q-sequence {q, q+1, …, q+k-1}.
        n = n & ~maskN;          // Here, 'maskN' converts bits {q, q+1, …, q+k-1} to '0', so that they are "vacant".
        n = n | sequenceP;       // Now 'n' receives the bits shifted from {p, p+1, …, p+k-1} to positions {q, q+1, …, q+k-1}.

        maskN = uint.MaxValue >> 31 - (k - 1);          // Mask with '1' on all bits is shifted right so that only k bits remain '1', all others become '0'.
        maskN = maskN << p;     // maskN is now shifted p bits to align with the p-sequence {p, p+1, …, p+k-1}.
        n = n & ~maskN;         // Here, 'maskN' converts bits {p, p+1, …, p+k-1} to '0', so that they are "vacant".
        n = n | sequenceQ;      // Now 'n' receives the bits shifted from {q, q+1, …, q+k-1} to positions {p, p+1, …, p+k-1}.
                                                // ---------- End of number-mask block. --------------
        Console.WriteLine("Binary representation for the modified 'n' is: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}