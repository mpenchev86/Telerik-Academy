/*
Problem 3. English digit
    • Write a method that returns the last digit of given integer as an English word.

Examples:

input   output

512     two 
1024    four 
12309   nine 

*/

using System;

class EnglishDigit
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(number));
    }

    private static string LastDigit(int number)
    {
        string word = string.Empty;
        switch (number % 10)
        {
            case 0:
                word = "zero"; break;
            case 1:
                word = "one"; break;
            case 2:
                word = "two"; break;
            case 3:
                word = "three"; break;
            case 4:
                word = "four"; break;
            case 5:
                word = "five"; break;
            case 6:
                word = "six"; break;
            case 7:
                word = "seven"; break;
            case 8:
                word = "eight"; break;
            case 9:
                word = "nine"; break;
        }
        return word;
    }
}
