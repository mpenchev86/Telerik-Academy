﻿/*
Problem 1. Numbers from 1 to N
    • Write a program that enters from the console a positive integer  n  and prints all the numbers from  1  to  n , on a single line, 
      separated by a space.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter positive integer: ");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i < n + 1; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}