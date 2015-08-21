/*
Problem 8. Isosceles Triangle
    • Write a program that prints an isosceles triangle of 9 copyright symbols  © , something like this:
  
   ©

  © ©

 ©   ©

© © © ©

Note: The  ©  symbol may be displayed incorrectly at the console so you may need to change the console character encoding to  UTF-8  
and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the  ©  symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
*/

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char copyrightSymbol = '\u0040';
        Console.WriteLine("   {0}\n\n  {0} {0}\n\n {0}   {0}\n\n{0} {0} {0} {0}", copyrightSymbol);   //Intervals are placed so that copyright symbols are roughly aligned to form the shape of a triangle. Absolute precision is not in my coding-skills' box yet:)
    }
}
