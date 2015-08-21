using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int COEFF = Math.Max(R, C);
            int N = int.Parse(Console.ReadLine());
            BigInteger[,] matrix = new BigInteger[R, C];
            bool[,] used = new bool[R, C];
            int[] CODEs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BigInteger num = 1;

            for (int i = 0; i < C; i++)
            {
                for (int j = R - 1; j >= 0; j--)
                {
                    matrix[j, i] = num << (R - 1 - j + i);
                    used[j, i] = false;
                }
            }

            BigInteger sum = 0;
            int curRow = R - 1;
            int curCol = 0;

            for (int i = 0; i < CODEs.Length; i++)
            {
                if (curCol > CODEs[i] % COEFF)
                {
                    for (; curCol - (CODEs[i] % COEFF) >= 0; curCol--)
                    {
                        if (used[curRow, curCol])
                        {
                            continue;
                        }
                        sum += matrix[curRow, curCol];
                        used[curRow, curCol] = true;
                    }
                    curCol++;
                }
                else
                {
                    for (; curCol - (CODEs[i] % COEFF) <= 0 ; curCol++)
                    {
                        if (used[curRow, curCol])
                        {
                            continue;
                        }
                        sum += matrix[curRow, curCol];
                        used[curRow, curCol] = true;
                    }
                    curCol--;
                }
                

                if (curRow > CODEs[i] / COEFF)
                {
                    for (; curRow - (CODEs[i] / COEFF) >= 0 ; curRow--)
                    {
                        if (used[curRow, curCol])
                        {
                            continue;
                        }
                        sum += matrix[curRow, curCol];
                        used[curRow, curCol] = true;
                    }
                    curRow++;
                }
                else
                {
                    for (; curRow - (CODEs[i] / COEFF) <= 0; curRow++)
                    {
                        if (used[curRow, curCol])
                        {
                            continue;
                        }
                        sum += matrix[curRow, curCol];
                        used[curRow, curCol] = true;
                    }
                    curRow--;
                }
                
            }

            Console.WriteLine(sum);
        }
    }
}
