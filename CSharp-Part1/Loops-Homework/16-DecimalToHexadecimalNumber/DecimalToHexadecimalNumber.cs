/*
Problem 16. Decimal to Hexadecimal Number
    • Using loops write a program that converts an integer number to its hexadecimal representation.
    • The input is entered as long. The output should be a variable of type string.
    • Do not use the built-in .NET functionality.
*/

using System;

class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number of type long: ");
        long decimalNum = long.Parse(Console.ReadLine());

        long tempDecimal = decimalNum;
        string hexaNum = "";
        for (int i = 15; i > -1; i--)
        {
            for (int j = 15; j > -1; j--)
			{
                if (j * Math.Pow(16, i) <= tempDecimal)
                {
                    switch (j)
                    {
                        case 15: hexaNum += "F"; break;
                        case 14: hexaNum += "E"; break;
                        case 13: hexaNum += "D"; break;
                        case 12: hexaNum += "C"; break;
                        case 11: hexaNum += "B"; break;
                        case 10: hexaNum += "A"; break;
                        case 9:
                        case 8:
                        case 7:
                        case 6: 
                        case 5:
                        case 4:
                        case 3:
                        case 2:
                        case 1: hexaNum += j; break;
                        case 0:
                            if (tempDecimal == decimalNum && tempDecimal != 0)
                            {
                                break;
                            }
                            else
                            {
                                hexaNum += 0;
                            }
                            break;
                        default:
                            break;
                    }
                    tempDecimal -= j * (long)Math.Pow(16, i);
                    break; 
                }
                    
			}
        }
        Console.WriteLine(hexaNum);
    }
}