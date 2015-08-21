/*
Problem 8. Prime Number Check
    • Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder 
      only to itself and 1).
    • Note: You should check if the number is positive
 */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter an integer between 0 and 100: ");
            parseCheck = int.TryParse(Console.ReadLine(), out n);
        } while (parseCheck == false || n < 0 || n > 100);
        
        int divisor = 1;
        int countDivisors = 0;
        do                              // It counts the number of integer divisors (in the range from 1 to n) of the specified number 'n'.
        {
            if (n % divisor == 0)
            {
                countDivisors++;
            }
            divisor++;
        } while (divisor <= n);
        
        Console.WriteLine("The number is {0}prime.", countDivisors == 2 ? "" : "NOT ");    // If 'countDivisors' equals 2, then 'n' is divisible by itself and 1, thus, 'n' is a prime number, adhering to the task's conditions.
        Console.WriteLine("Divisors' count: {0}", countDivisors);        // It helped when analyzing some variations of the loop's while condition.
    }
}