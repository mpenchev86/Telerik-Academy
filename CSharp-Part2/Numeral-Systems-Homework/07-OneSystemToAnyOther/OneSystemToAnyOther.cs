/*
Problem 7. One system to any other
    • Write a program to convert from any numeral system of given base  s  to any other numeral system of base  d  (2 ≤  s ,  d  ≤ 16).
*/

using System;
using System.Collections.Generic;
using System.Numerics;

public class OneSystemToAnyOther
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numeral system base s (2 <= s <= 16):");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number to convert:");
        string inputNum = Console.ReadLine().ToUpperInvariant();
        char[] number = inputNum.ToCharArray();
        Array.Reverse(number);

        Console.WriteLine("Enter numeral system base d (2 <= d <= 16):");
        int d = int.Parse(Console.ReadLine());

        char[] toDecimal = ToDecimal(number, s);

        char[] toDBase = ToBaseD(toDecimal, d);
        Console.WriteLine("The number in numeral system with base {0}: ", d);
        PrintNumber(toDBase);

    }

    public static void PrintNumber(char[] converted)
    {
        for (int i = 0; i < converted.Length; i++)
        {
            Console.Write(converted[i]);
        }
        Console.WriteLine();
    }

    static BigInteger MathPow(int d, int power)
    {
        BigInteger result = 1;
        
        for (int i = 0; i < power; i++)
        {
            result *= d;
        }
        
        return result;
    }

    public static char[] ToBaseD(char[] toDecimal, int d)
    {
        string arrayNum = new string(toDecimal);
        long tempDecimal = Convert.ToInt64(arrayNum);

        List<long> tempResult = new List<long>();

        int power = 0;
        while (tempDecimal >= MathPow(d, power))
        {
            power++;
        }

        power--;
        long hexDigit = tempDecimal / (long)MathPow(d, power);
        tempDecimal -= hexDigit * (long)MathPow(d, power);
        tempResult.Add(hexDigit);
        power--;

        for (; power > -1; power--)
        {
            if (tempDecimal < MathPow(d, power))
            {
                tempResult.Add(0);
                continue;
            }
            hexDigit = tempDecimal / (long)MathPow(d, power);
            tempDecimal -= hexDigit * (long)MathPow(d, power);
            tempResult.Add(hexDigit);
        }

        char[] result = new char[tempResult.Count];
        for (int i = 0; i < tempResult.Count; i++)
        {
            switch (tempResult[i])
            {
                case 0:
                result[i] = '0';
                break;
                case 1:
                result[i] = '1';
                break;
                case 2:
                result[i] = '2';
                break;
                case 3:
                result[i] = '3';
                break;
                case 4:
                result[i] = '4';
                break;
                case 5:
                result[i] = '5';
                break;
                case 6:
                result[i] = '6';
                break;
                case 7:
                result[i] = '7';
                break;
                case 8:
                result[i] = '8';
                break;
                case 9:
                result[i] = '9';
                break;
                case 10:
                result[i] = 'A';
                break;
                case 11:
                result[i] = 'B';
                break;
                case 12:
                result[i] = 'C';
                break;
                case 13:
                result[i] = 'D';
                break;
                case 14:
                result[i] = 'E';
                break;
                case 15:
                result[i] = 'F';
                break;
            }
        }

        return result;
    }

    public static char[] ToDecimal(char[] number, int s)
    {
        char[] result = new char[] { };
        int tempResult = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int value = 0;
            switch (number[i])
            {
                case '0':
                value = 0;
                break;
                case '1':
                value = 1;
                break;
                case '2':
                value = 2;
                break;
                case '3':
                value = 3;
                break;
                case '4':
                value = 4;
                break;
                case '5':
                value = 5;
                break;
                case '6':
                value = 6;
                break;
                case '7':
                value = 7;
                break;
                case '8':
                value = 8;
                break;
                case '9':
                value = 9;
                break;
                case 'A':
                value = 10;
                break;
                case 'B':
                value = 11;
                break;
                case 'C':
                value = 12;
                break;
                case 'D':
                value = 13;
                break;
                case 'E':
                value = 14;
                break;
                case 'F':
                value = 15;
                break;
            }
            tempResult += value * (int)MathPow(s, i);
        }
        result = Convert.ToString(tempResult).ToCharArray();
        return result;
    }
}