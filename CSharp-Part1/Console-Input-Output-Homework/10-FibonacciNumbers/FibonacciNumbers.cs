/*
Problem 10. Fibonacci Numbers
    • Write a program that reads a number  n  and prints on the console the first  n  members of the Fibonacci sequence (at a single line, 
      separated by comma and space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .
Note: You may need to learn how to use loops.
*/

using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program reads a number  n  and prints on the console the first  n"
            + "\n" + "members of the Fibonacci sequence (at a single line, separated by comma and" 
            + "\n" + "space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … " + "\n");

        int n;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid 'n' number (n >= 1): ");
            parseCheck = int.TryParse(Console.ReadLine(), out n);
        } while (!parseCheck || n < 1);
        int lastNumber = 0;
        int nextNumber = 1;
        int bridgeLastNext;
        if (n == 1)
        {
            Console.Write("The first  1  numbers of the Fibonacci sequence: 0, " + "\n");
        }
        else if (n == 2)
        {
            Console.Write("The first  2  numbers of the Fibonacci sequence: 0, 1, " + "\n");
        }
        else
        {
            Console.Write("The first {0} numbers of the Fibonacci sequence are: 0, 1, ", n);
            for (int i = 2; i < n; i++)             // The first two iterations do not follow the mathematical logic of the next ones. That is why they are executed separately.
            {
                bridgeLastNext = nextNumber;                // Keeps the current value of 'nextNumber'.
                nextNumber = nextNumber + lastNumber;       // 'nextNumber' is assigned the next value in the sequence
                lastNumber = bridgeLastNext;                // 'lastnumber' is assigned the former value of 'nextNumber'
                Console.Write("{0}, ", nextNumber);
            }
            Console.WriteLine();
        }

    }
}