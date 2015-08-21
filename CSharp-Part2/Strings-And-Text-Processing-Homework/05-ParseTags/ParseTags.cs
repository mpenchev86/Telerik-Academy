/*
Problem 5. Parse tags
    • You are given a text. Write a program that changes the text in all regions surrounded by the tags  <upcase>  and  </upcase>  to 
      upper-case.
    • The tags cannot be nested.

Example: We are living in a  <upcase> yellow submarine </upcase> . We don't have  <upcase> anything </upcase>  else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());

            int indexOpen = input.ToString().IndexOf(">");
            int indexClose = input.ToString().IndexOf("<", indexOpen);

            while (indexOpen != -1 && indexClose != -1)
            {
                StringBuilder temp = new StringBuilder();
                for (int i = indexOpen + 1; i < indexClose; i++)
                {
                    temp.Append(input[i]);
                }
                input.Replace(temp.ToString(), temp.ToString().ToUpperInvariant(), indexOpen + 1, indexClose - 1);
                indexOpen = input.ToString().IndexOf(">", indexClose);
                indexOpen = input.ToString().IndexOf(">", indexOpen + 1);
                indexClose = input.ToString().IndexOf("<", indexOpen);
            }

            Console.WriteLine(input);
        }
    }
}
