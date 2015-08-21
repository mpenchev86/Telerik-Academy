/*
Problem 8. Binary short
    • Write a program that shows the binary representation of given 16-bit signed integer number (the C# type  short ).
*/

using System;
using System.Text;

class BinaryShort
{
    static void Main(string[] args)
    {
        Console.Write("Enter signed short integer number: ");
        StringBuilder input = new StringBuilder();
        input.Append(Console.ReadLine());

        Console.WriteLine("Binary representation: ");

        if (input[0] == '-')
        {
            input.Remove(0, 1);
            char[] inputAfterSign = input.ToString().ToCharArray();
            short negativeAfterSigh = (short)(Math.Pow(2, 15) - Convert.ToInt16(input.ToString()));
            char[] negativeBinary = OneSystemToAnyOther.ToBaseD(negativeAfterSigh.ToString().ToCharArray(), 2);

            Console.Write("1");
            for (int i = 0; i < 15 - negativeBinary.Length; i++)
            {
                Console.Write("0");
            }
            OneSystemToAnyOther.PrintNumber(negativeBinary);
        }
        else
        {
            char[] inputAfterSign = input.ToString().ToCharArray();
            char[] result = OneSystemToAnyOther.ToBaseD(inputAfterSign, 2);
            for (int i = 0; i < 16 - result.Length; i++)
            {
                Console.Write("0");
            }
            OneSystemToAnyOther.PrintNumber(result);
        }

    }
}