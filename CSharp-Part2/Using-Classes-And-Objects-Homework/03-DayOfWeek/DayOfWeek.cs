/*
Problem 3. Day of week
    • Write a program that prints to the console which day of the week is today.
    • Use  System.DateTime .
*/

using System;
using System.Threading;
using System.Globalization;

class DayOfWeek
{
    static void Main(string[] args)
        {
            Console.WriteLine("Today is {0}.", DateTime.Today.DayOfWeek);
        }
}