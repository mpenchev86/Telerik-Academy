/*
Problem 7. Sort 3 Numbers with Nested Ifs
    • Write a program that enters 3 real numbers and prints them sorted in descending order. 
        ◦ Use nested  if  statements.
Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;
using System.Globalization;
using System.Threading;

class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first real number: ");
            double realNum1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter second real number: ");
            double realNum2 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter third real number: ");
            double realNum3 = double.Parse(Console.ReadLine());
            
            string printOrder = "The numbers in descending order: {0} {1} {2}";     // A template is created to be reused for printing every order variation.

            if (realNum1 >= realNum2)
            {
                if (realNum1 >= realNum3)
                {
                    if (realNum2 >= realNum3)           // realNum1 >= realnum2 >= realnum3
                    {
                        Console.WriteLine(printOrder, realNum1, realNum2, realNum3);    
                    }
                    else                                // realNum1 >= realnum3 >= realnum2
                    {
                        Console.WriteLine(printOrder, realNum1, realNum3, realNum2);
                    }
                }
                else                                    // realNum3 >= realnum1 >= realnum2
                {
                    Console.WriteLine(printOrder, realNum3, realNum1, realNum2);
                }
            }
            else
            {
                if (realNum2 >= realNum3)
                {
                    if (realNum3 >= realNum1)           // realNum2 >= realnum3 >= realnum1
                    {
                        Console.WriteLine(printOrder, realNum2, realNum3, realNum1);
                    }
                    else                                // realNum2 >= realnum1 >= realnum3
                    {
                        Console.WriteLine(printOrder, realNum2, realNum1, realNum3);
                    }
                }
                else                                    // realNum3 >= realnum2 >= realnum1
                {
                    Console.WriteLine(printOrder, realNum3, realNum2, realNum1);
                }
            }
        }
    }
