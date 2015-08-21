/*
Problem 14. Modify a Bit at Given Position
    • We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
    • Write a sequence of operators (a few lines of C# code) that modifies  n  to hold the value  v  at the position  p  
      from the binary representation of  n  while preserving all other bits in  n .
 */

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int n;
        int p;
        int v;
        
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
        parseCheck = false;
        do
        {
            Console.Write("Enter valid bit value: ");
            parseCheck = int.TryParse(Console.ReadLine(), out v);
        } while (parseCheck == false || v!=0 && v!=1);
        
        int mask;
        int maskAndN;
        int newN;
        mask = ~(1 << p);           // Inverts the ..00001000000.. mask ---> ..11110111111..
        maskAndN = mask & n;        // Bitwise & with the ..11101111.. mask only assigns '0' to bit #p in 'n'. There's no other difference between 'n' and 'maskAndN'.
        mask = v << p;              // 'mask' now is assigned a regular, ..000v0000.. mask with '1' in bit #p
        newN = mask | maskAndN;     // Bitwise | with the ..000v0000.. mask only assigns 'v' to bit #p in 'maskAndN'. So bit #p in 'n' has been changed first to '0' and then to 'v'.
        Console.WriteLine("Binary n    is: {0}" + "\n" + "Binary newN is: {1}", 
            Convert.ToString(n, 2).PadLeft(32, '0'), Convert.ToString(newN, 2).PadLeft(32, '0'));


    }
}