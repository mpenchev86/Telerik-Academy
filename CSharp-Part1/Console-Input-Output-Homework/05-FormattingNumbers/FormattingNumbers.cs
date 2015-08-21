/*
Problem 5. Formatting Numbers
    • Write a program that reads 3 numbers: 
        ◦ integer  a  (0 <= a <= 500)
        ◦ floating-point  b  
        ◦ floating-point  c
    • The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
        ◦ The number  a  should be printed in hexadecimal, left aligned
        ◦ Then the number  a  should be printed in binary form, padded with zeroes
        ◦ The number  b  should be printed with 2 digits after the decimal point, right aligned
        ◦ The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine
            ("This program reads 3 numbers:" + "\n  \u002D" + "integer  a  (0 <= a <= 500)" 
            + "\n  \u002D" + "floating-point  b" + "\n  \u002D" + "floating-point  c"
            + "\n"+ "The program then prints them in 4 virtual columns on the console. Each column" 
            + "\n"+ "should have a width of 10 characters."
            + "\n  \u002D" + "The number  a  should be printed in hexadecimal, left aligned"
            + "\n  \u002D" + "Then the number  a  should be printed in binary form, padded with zeroes"
            + "\n  \u002D" + "The number  b  should be printed with 2 digits after the decimal point," 
            + "\n   " + "right aligned"
            + "\n  \u002D" + "The number c should be printed with 3 digits after the decimal point," 
            + "\n   " + "left aligned." + "\n");
        int a;
        double b;
        double c;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter a valid integer number 'a' (0 <= a <= 500): ");
            parseCheck = int.TryParse(Console.ReadLine(), out a);
        } while (!parseCheck || a < 0 || a > 500);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid floating-point number 'b': ");
            parseCheck = double.TryParse(Console.ReadLine(), out b);
        } while (!parseCheck);
        parseCheck = false;
        do
        {
            Console.Write("Enter a valid floating-point number 'c': ");
            parseCheck = double.TryParse(Console.ReadLine(), out c);
        } while (!parseCheck);
        Console.WriteLine("\n"+"{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|",a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c );
    }
}
