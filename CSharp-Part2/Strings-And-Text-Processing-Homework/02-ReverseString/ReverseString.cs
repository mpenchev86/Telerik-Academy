/*
Problem 2. Reverse string
    • Write a program that reads a string, reverses it and prints the result at the console.
Example:

 input    output

sample    elpmas 
*/

using System;
using System.Text;

namespace _02_ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string inputString = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result.Append(inputString[i]);
            }

            Console.WriteLine(result);
        }
    }
}
