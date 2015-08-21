using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNum = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < inputNum.Length; i++)
            {
                char[] number = inputNum[i].ToCharArray();

                Array.Reverse(number);

                char[] toDecimal = ToDecimal(number, 21);

                char[] toDBase = ToBaseD(toDecimal, 26);
                PrintNumber(toDBase);

                if (i < inputNum.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        public static void PrintNumber(char[] converted)
        {
            for (int i = 0; i < converted.Length; i++)
            {
                Console.Write(converted[i]);
            }
        }

        public static char[] ToBaseD(char[] toDecimal, int d)
        {
            string arrayNum = new string(toDecimal);
            ulong tempDecimal = Convert.ToUInt64(arrayNum);
            //result = new char[]{};

            if (tempDecimal == 0)
            {
                char[] result1 = new char[] { '0' };
                return result1;
            }

            List<ulong> tempResult = new List<ulong>();

            int power = 0;
            while (tempDecimal >= Math.Pow(d, power))
            {
                power++;
            }

            power--;
            ulong hexDigit = tempDecimal / (ulong)Math.Pow(d, power);
            tempDecimal -= hexDigit * (ulong)Math.Pow(d, power);
            tempResult.Add(hexDigit);
            power--;

            if (tempDecimal != 0)
            {
                for (; power > -1; power--)
                {
                    if (tempDecimal < (ulong)Math.Pow(d, power))
                    {
                        tempResult.Add(0);
                        continue;
                    }
                    hexDigit = tempDecimal / (ulong)Math.Pow(d, power);
                    tempDecimal -= hexDigit * (ulong)Math.Pow(d, power);
                    tempResult.Add(hexDigit);
                }
            }

            char[] result = new char[tempResult.Count];
            for (int i = 0; i < tempResult.Count; i++)
            {
                switch (tempResult[i])
                {
                    case 0:
                    result[i] = 'a';
                    break;
                    case 1:
                    result[i] = 'b';
                    break;
                    case 2:
                    result[i] = 'c';
                    break;
                    case 3:
                    result[i] = 'd';
                    break;
                    case 4:
                    result[i] = 'e';
                    break;
                    case 5:
                    result[i] = 'f';
                    break;
                    case 6:
                    result[i] = 'g';
                    break;
                    case 7:
                    result[i] = 'h';
                    break;
                    case 8:
                    result[i] = 'i';
                    break;
                    case 9:
                    result[i] = 'j';
                    break;
                    case 10:
                    result[i] = 'k';
                    break;
                    case 11:
                    result[i] = 'l';
                    break;
                    case 12:
                    result[i] = 'm';
                    break;
                    case 13:
                    result[i] = 'n';
                    break;
                    case 14:
                    result[i] = 'o';
                    break;
                    case 15:
                    result[i] = 'p';
                    break;
                    case 16:
                    result[i] = 'q';
                    break;
                    case 17:
                    result[i] = 'r';
                    break;
                    case 18:
                    result[i] = 's';
                    break;
                    case 19:
                    result[i] = 't';
                    break;
                    case 20:
                    result[i] = 'u';
                    break;
                    case 21:
                    result[i] = 'v';
                    break;
                    case 22:
                    result[i] = 'w';
                    break;
                    case 23:
                    result[i] = 'x';
                    break;
                    case 24:
                    result[i] = 'y';
                    break;
                    case 25:
                    result[i] = 'z';
                    break;
                }
            }

            return result;
        }

        public static char[] ToDecimal(char[] number, int s)
        {
            char[] result = new char[] { };
            ulong tempResult = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int value = 0;
                switch (number[i])
                {
                    case 'a':
                    value = 0;
                    break;
                    case 'b':
                    value = 1;
                    break;
                    case 'c':
                    value = 2;
                    break;
                    case 'd':
                    value = 3;
                    break;
                    case 'e':
                    value = 4;
                    break;
                    case 'f':
                    value = 5;
                    break;
                    case 'g':
                    value = 6;
                    break;
                    case 'h':
                    value = 7;
                    break;
                    case 'i':
                    value = 8;
                    break;
                    case 'j':
                    value = 9;
                    break;
                    case 'k':
                    value = 10;
                    break;
                    case 'l':
                    value = 11;
                    break;
                    case 'm':
                    value = 12;
                    break;
                    case 'n':
                    value = 13;
                    break;
                    case 'o':
                    value = 14;
                    break;
                    case 'p':
                    value = 15;
                    break;
                    case 'q':
                    value = 16;
                    break;
                    case 'r':
                    value = 17;
                    break;
                    case 's':
                    value = 18;
                    break;
                    case 't':
                    value = 19;
                    break;
                    case 'u':
                    value = 20;
                    break;
                }
                tempResult += (ulong)value * (ulong)Math.Pow(s, i);
            }
            result = Convert.ToString(tempResult).ToCharArray();
            return result;
        }
    }
}
