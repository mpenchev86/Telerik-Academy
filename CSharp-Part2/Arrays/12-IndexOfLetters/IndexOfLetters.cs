/*
Problem 12. Index of letters
    • Write a program that creates an array containing all letters from the alphabet ( A-Z ).
    • Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] arrAlphabet = new char[26];
        for (int i = 0; i < arrAlphabet.Length; i++)
        {
            arrAlphabet[i] = (char)(65 + i);
        }

        Console.Write("Enter word: ");
        string wordInput = Console.ReadLine();

        Console.WriteLine("Letters indices in the array:");
        foreach (char letter in wordInput)
        {
            for (int i = 0; i < arrAlphabet.Length; i++)
            {
                if (arrAlphabet[i] == letter)
                {
                    Console.WriteLine("{0} - {1}", letter, i);
                    break;
                }
                else if (i == 25)
                {
                    Console.WriteLine("'{0}' is not in the array", letter);
                }
            }
        }
    }
}