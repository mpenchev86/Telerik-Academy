/*
Problem 2. Random numbers
    • Write a program that generates and prints to the console  10  random values in the range [ 100, 200 ].
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RandomNumbers
{
    class RandomNumbers
    {
        static Random x = new Random();
        static void Main(string[] args)
        {
            Console.Write("values in the range [ 100, 200 ]: ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9)
                {
                    Console.Write(x.Next(100, 201) + ", ");
                }
            }
            Console.WriteLine(x.Next(100, 201));
        }
    }
}
