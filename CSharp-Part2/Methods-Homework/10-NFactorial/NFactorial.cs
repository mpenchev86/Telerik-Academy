/*
Problem 10. N Factorial
    • Write a program to calculate  n!  for each  n  in the range [ 1..100 ].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class NFactorial
{
    static void Main(string[] args)
    {
        int p = 4;
        char[] num = new char[Convert.ToString(p).Length];
        ReverseDigits(num);

        List<char> result = new List<char>();
        result.Add('1');

        Console.WriteLine("Enter n, 1 <= n <= 100: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            char[] array = Convert.ToString(i).ToCharArray();
            for (int j = 0; j < array.Length; j++)
            {
                char[] tempSum = MultiplyArray(result.ToArray(), array[j], j);
            }            
                
        }

        int digit = 6;
        char[] num2 = MultiplyArray(num, digit, 0);
        ReverseDigits(num2);
    }

    private static char[] MultiplyArray(char[] num, int digit, int power)
    {
        StringBuilder tempResult = new StringBuilder();
        int temp = 0;
        for (int i = 0; i < num.Length; i++)
        {
            tempResult.Insert(0, (temp + ((int)num[i] - 48) * digit) % 10);
            if ((temp + ((int)num[i] - 48) * digit) / 10 > 0)
            {
                temp = (temp + ((int)num[i] - 48) * digit) / 10;
            }
            else
            {
                temp = 0;
            }
        }

        if (temp != 0)
        {
            tempResult.Insert(0, temp);
        }

        for (int i = 0; i < power; i++)
        {
            tempResult.Append(0);
        }

        char[] result = tempResult.ToString().ToCharArray();
        ReverseDigits(result);
        return result;
    }

    private static char[] AddArrays(char[] array1, char[] array2)
    {
        StringBuilder tempResult = new StringBuilder();
        int temp = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            tempResult.Insert(0, (temp + ((int)array1[i] - 48) + ((int)array2[i] - 48)) % 10);
            if ((temp + ((int)array1[i] - 48) + ((int)array2[i] - 48)) / 10 > 0)
            {
                temp = (temp + ((int)array1[i] - 48) + ((int)array2[i] - 48)) / 10;
            }
            else
            {
                temp = 0;
            }
        }

        for (int i = array2.Length; i < array1.Length; i++)
        {
            tempResult.Insert(0, (temp + ((int)array1[i] - 48)) % 10);
            if ((temp + ((int)array1[i] - 48)) / 10 > 0)
            {
                temp = (temp + ((int)array1[i] - 48)) / 10;
            }
            else
            {
                temp = 0;
            }
        }

        if (temp != 0)
        {
            tempResult.Insert(0, temp);
        }

        char[] result = tempResult.ToString().ToCharArray();
        ReverseDigits(result);
        return result;
    }

    private static void ReverseDigits(char[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            char temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }
}