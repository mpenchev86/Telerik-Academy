/*
Problem 7. Reverse number
    • Write a method that reverses the digits of given decimal number.

Example:

input   output

256     652 
123.45  54.321 
*/

using System;
using System.Threading;
using System.Globalization;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());

        decimal result = ReverseDigits(number);
        Console.WriteLine(result);
    }

    private static decimal ReverseDigits(decimal number)
    {
        char[] digits = Convert.ToString(number).ToCharArray();
        string reversed = string.Empty;
        int j = 0;

        if (digits[0] == '-')
        {
            reversed += digits[0];
            j++;
        }
        
        for ( int i = digits.Length - 1; i > j - 1; i--)
        {
            reversed += digits[i];
        }

        decimal result = Convert.ToDecimal(reversed);
        return result;
    }
}