/*
Problem 8. Numbers from 1 to n
    • Write a program that reads an integer number  n  from the console and prints all the numbers in the interval  [1..n] , each on a single 
      line.
Note: You may need to use a for-loop.
*/

using System;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program reads an integer number  n  from the console and prints all the" 
            + "\n" + "numbers in the interval  [1..n] , each on a single line." + "\n");
        int n;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid integer: ");
            parseCheck = int.TryParse(Console.ReadLine(), out n);
        } while (!parseCheck);
        if (n >= 1)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
        if (n < 1)
        {
            Console.WriteLine("1" + "\n" + "0");
            for (int i = 0; i < Math.Abs(n); i++)
            {
                Console.WriteLine(-(i + 1));
            }
        }
    }
}