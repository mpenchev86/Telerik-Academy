/*
Problem 6. String length
    • Write a program that reads from the console a string of maximum  20  characters. If the length of the string is less than  20 , 
      the rest of the characters should be filled with  * .
    • Print the result string into the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(20, 20);
            for (int i = 0; i < 20; i++)
            {
                if (input.Length <= 20)
                {
                    if (i >= input.Length)
                    {
                        result.Append("*");
                        continue;
                    }
                    result.Append(input[i]);
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result);

        }
    }
}
