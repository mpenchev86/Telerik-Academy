/*
Problem 4. Sub-string in text
    • Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive 
      search).

Example:

The target sub-string is  in 

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is 
very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is:  9 
*/

using System;
using System.Text;

namespace _04_SubStringInText
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();
            int index = input.IndexOf(sub, StringComparison.CurrentCultureIgnoreCase);
            int count = 0;
            while (index != -1)
            {
                index = input.IndexOf(sub, index + 1, StringComparison.CurrentCultureIgnoreCase);
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("{0} can't be found in the text.", sub);
            }
            else
            {
                Console.WriteLine("{0} is found {1} times.", sub, count);
            }
        }
    }
}
