/*
Problem 9. Sum of n Numbers
    • Write a program that enters a number  n  and after that enters more  n  numbers and calculates and prints their  sum . 
Note: You may need to use a for-loop.
*/

using System;
using System.Globalization;
using System.Threading;

class SumOfnNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program enters a number  n  and after that enters more  n  numbers and" + "\n" + "calculates and prints their  sum." + "\n");
        
        int n;
        double newNumbers;
        double sumNumbers = 0;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid 'n' number (n >= 1): ");
            parseCheck = int.TryParse(Console.ReadLine(), out n);
        } while (!parseCheck || n < 1);

        for (int i = 0; i < n; i++)
        {
            parseCheck = false;
            do
            {
                Console.Write("Enter a valid #{0} addend number: ", i + 1);
                parseCheck = double.TryParse(Console.ReadLine(), out newNumbers);
            } while (!parseCheck);
            if (parseCheck)
            {
                sumNumbers += newNumbers;
            }
        }

        Console.WriteLine("\n"+"The sum of the numbers is: {0}", sumNumbers);
    }
}