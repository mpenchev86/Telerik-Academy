/*
Problem 7. Sum of 5 Numbers
    • Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

using System;
using System.Globalization;
using System.Threading;


class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine
            ("This program enters 5 numbers (given in a single line, separated by a space)," + "\n" + "calculates and prints their sum.");

        double[] arrayNumbers = new double[5];                                      // This array keeps the digital representation of the numbers in double values.
        string[] arrayStrings = new string[] { null, null, null, null, null };      // This array keeps the string representation of the numbers.
        int lastKey = 0;                                                            // It serves to mark the decimal representation of the last pressed key by the user.

        Console.Write
            ("\n" + "Enter five numbers: ");
        for (int i = 0; i < 5; i++)
        {
            ConsoleKeyInfo currentKey = Console.ReadKey();                      // Gets the description of the pressed key
            lastKey = currentKey.KeyChar;                                       // Assignes 'lastKey' the numerical representation of the pressed key
            if (lastKey >= 44 && lastKey <= 57 && lastKey != 47)                // If the key was ',' or '-' or '.' or between 0-9 (look up ASCII table)
            {
                arrayStrings[i] += (char)lastKey;                               // Adds the character behind the numerical value to the corresponding element of the string array
                i--;                                                            // To keep adding new characters to this string array element, 'i' has to stay the same in the next iteration of the loop.
            }
            else if (lastKey == 32 && arrayStrings[i] != null)                  // If the string element isn't empty and SPACE is pressed
            {
                arrayNumbers[i] = double.Parse(arrayStrings[i]);                // The double values array element receives the parsed value of it's corresponding string element
                arrayStrings[i] += " ";                                         // This interval is concatenated so the next element visualized in the console doesn't start right next to the previous
                continue;                                                       // It concludes the iteration and continues with the next element
            }
            else if (lastKey == 13 && i == 4 && arrayStrings[i] != null)         // This is activated when the user has finished entering the numbers.
            {
                arrayNumbers[i] = double.Parse(arrayStrings[i]);
                break;                                                           //All elements are assinged values and pressing enter exits the loop.
            }
            else                                                                 // In all other cases the console gets cleared and returned to the state of the previously pressed key.
            {
                Console.Clear();
                Console.WriteLine
                    ("This program enters 5 numbers (given in a single line, separated by a space)," + "\n" + "calculates and prints their sum.");
                Console.Write
                    ("\n" + "Enter five numbers: {0}{1}{2}{3}{4}", arrayStrings[0], arrayStrings[1], arrayStrings[2], arrayStrings[3], arrayStrings[4]);
                i--;                                                            // It is necessary to reset the iterator so that the user can continue adding characters to the current element
                continue;
            }
        }
   
        Console.WriteLine("\n" + "The sum of the numbers is: {0}", arrayNumbers[0] + arrayNumbers[1] + arrayNumbers[2] + arrayNumbers[3] + arrayNumbers[4]);
    }
}