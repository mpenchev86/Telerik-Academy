/*
Problem 3. Check for a Play Card
    • Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program 
      that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
*/

using System;

class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string[] cardFaces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.Write("\n" + "Enter a valid card face: ");
        string inputStr = Console.ReadLine();
        for (int i = 0; i < 13; i++)
        {
            if (inputStr.Equals(cardFaces[i], StringComparison.Ordinal))    // Compares the entered string with every string in the array 'cardFaces[]'.
            {
                Console.WriteLine("Yes.");
                break;
            }
            else if (i == 12)                                               // If the string is not identical in any string in the array, it returns 'No.'
            {
                Console.WriteLine("No.");
            }
        }
    }
}