/*
Problem 11.* Number as Words
    • Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/

using System;

class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number in the range [0…999]: ");
        int inputNum = int.Parse(Console.ReadLine());
        if (inputNum < 0 || inputNum > 999)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        string[] oneToNine = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };   // An array for the digits - [1...9]
        string[] tenToNineteen = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };   // Array for - [10...19]
        string[] twentyToNinety = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };  // Array for the '10-s' - [20, 30...90]
        // The values in the string arrays are concatenated according to the dependencies expressed in the if-statements below to match the linguistic representation of the number.

        if (inputNum / 100 > 0)                                                 // If the number is >= 100, we print the digit for hundreds on the same line.
        {
            Console.Write("{0} hundred", oneToNine[inputNum / 100 - 1]);        
            if (inputNum % 100 != 0)                                            
            {
                Console.Write(" and ");                                         // If the number isn't dividable by 100, we concatenate " and ", waiting for the rest of the number.
            }
            else
            {
                Console.WriteLine();                                            // If the number is dividable by 100, no further concatenation is needed. 
            }
        }

        if (inputNum % 100 > 19)                                                // If The 10s part is > 19, we concatenate the corresponding value from 'twentyToNinety[]'
        {
            Console.Write("{0} ", twentyToNinety[(inputNum % 100) / 10 - 2]);
            if (((inputNum % 100) % 10) > 0)                                    // And if the digits part is > 0, we concatenate the corresponding value from 'oneToNine[]'
            {
                Console.Write("{0} " + "\n", oneToNine[(inputNum % 100) % 10 - 1]);
            }
            else
            {
                Console.WriteLine();
            }
        }
        else                                                                    // If The 10s part is <= 19 but > 9, we concatenate the corresponding value from 'tenToNineteen[]'
        {
            if (inputNum % 100 > 9)
            {
                Console.Write("{0} " + "\n", tenToNineteen[inputNum % 100 - 10]);
            }
            else                                                                // If the 10s part is empty, we concatenate the corresponding value from 'oneToNine[]'
            {
                if (inputNum % 100 > 0)                 
                {
                    Console.Write("{0} " + "\n", oneToNine[inputNum % 100 - 1]);
                }
            }
        }

        if (inputNum == 0)                                                      // Finally, if the number is 0 - "zero"
        {
            Console.WriteLine("zero");
        }
    }
}