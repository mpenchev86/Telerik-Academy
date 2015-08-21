/*
Problem 2. Bonus Score
    • Write a program that applies bonus score to given score in the range  [1…9]  by the following rules: 
        ◦ If the score is between  1  and  3 , the program multiplies it by  10 .
        ◦ If the score is between  4  and  6 , the program multiplies it by  100 .
        ◦ If the score is between  7  and  9 , the program multiplies it by  1000 .
        ◦ If the score is  0  or more than  9 , the program prints  “invalid score” .
*/
using System;

class BonusScore
{
    static void Main(string[] args)
    {
        int scoreInput;
        bool parseCheck = false;
        do
        {
            Console.Write("Enter score [0...9]: ");
            parseCheck = int.TryParse(Console.ReadLine(), out scoreInput);
        } while (!parseCheck);
        if (scoreInput <= 0 || scoreInput > 9)      
        {
            Console.WriteLine("Invalid score.");
        }
        else if (scoreInput <= 3)                   
        {
            Console.WriteLine("The score is: {0}", scoreInput *= 10);
        }
        else if (scoreInput <= 6)                 
        {
            Console.WriteLine("The score is: {0}", scoreInput *= 100);
        }
        else if (scoreInput <= 9)
        {
            Console.WriteLine("The score is: {0}", scoreInput *= 1000);
        }
    }
}