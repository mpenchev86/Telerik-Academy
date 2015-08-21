/*
Problem 3. Correct brackets
    • Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression:  ((a+b)/5-d) . Example of incorrect expression:  )(a+b)) .
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.Write("Enter expression: ");
            string input = Console.ReadLine();

            int indexOpen = input.ToString().IndexOf("(");
            int indexClose = input.ToString().IndexOf(")", indexOpen);
            int countOpen = 0;
            int countClose = 0;

            while (indexOpen != 0)
            {
                countOpen++;
                indexOpen = input.ToString().IndexOf("(", indexOpen + 1);
            }
            while (indexClose != 0)
            {
                countClose++;
                indexClose = input.ToString().IndexOf(")", indexOpen);
            }

            if (countOpen != countClose)
            {
                Console.WriteLine("Incorrect expression.");
                return;
            }
            else
            {

            }
        }
    }
}
