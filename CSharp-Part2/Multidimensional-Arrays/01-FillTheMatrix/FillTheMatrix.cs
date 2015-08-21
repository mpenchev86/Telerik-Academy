/*
Problem 1. Fill the matrix
    • Write a program that fills and prints a matrix of size  (n, n)  as shown below:
Example for  n=4 :
    a)              b)              c)              d)*
1 5 9 13        1 8 9 16        7 11 14 16      1 12 11 10
2 6 10 14       2 7 10 15       4 8 12 15       2 13 16 9 
3 7 11 15       3 6 11 14       2 5 9 13        3 14 15 8 
4 8 12 16       4 5 12 13       1 3 6 10        4 5 6 7 
*/

using System;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter matrix size: ");
        int size = int.Parse(Console.ReadLine());
        
        char choiseTypeMatrix = 'z';
        while (choiseTypeMatrix != 'a' && choiseTypeMatrix != 'A' &&
               choiseTypeMatrix != 'b' && choiseTypeMatrix != 'B' &&
               choiseTypeMatrix != 'c' && choiseTypeMatrix != 'C' && 
               choiseTypeMatrix != 'd' && choiseTypeMatrix != 'D')
        {
            Console.Write("Choose order of numbers in the matrix ('a', 'b', 'c' or 'd'): ");
            choiseTypeMatrix = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Type {0}):", choiseTypeMatrix);

        int[,] matrix = new int[size, size];
        int tempNum = 1;

        if (choiseTypeMatrix == 'a' || choiseTypeMatrix == 'A')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[j, i] = tempNum;
                    tempNum++;
                }
            }
            
        }
        if (choiseTypeMatrix == 'b' || choiseTypeMatrix == 'B')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 != 0)
                    {
                        matrix[size - j - 1, i] = tempNum;
                    }
                    else
                    {
                        matrix[j, i] = tempNum;
                    }
                    tempNum++;
                }
            }
        }
        if (choiseTypeMatrix == 'c' || choiseTypeMatrix == 'C')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    matrix[size - 1 - (i - j), j] = tempNum;
                    tempNum++;    
                }
            }
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[j, ((size - 1) - i) + (j + 1)] = tempNum;
                    tempNum++;
                }
            }
        }
        if (choiseTypeMatrix == 'd' || choiseTypeMatrix == 'D')
        {
            int limRowCol = size - 1;
            int nextNum = 0;
            int rowOrCol = 0;

            do
            {
                if (size == 1)
                {
                    matrix[0, 0] = 1;
                    break;
                }

                
                for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Column Down
                {
                    nextNum++;
                    matrix[i, rowOrCol] = nextNum;
                }
                for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Row to the Right
                {
                    nextNum++;
                    matrix[limRowCol - rowOrCol, i] = nextNum;
                }
                for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Column Up
                {
                    nextNum++;
                    matrix[limRowCol - i, limRowCol - rowOrCol] = nextNum;
                }
                for (int i = rowOrCol; i < limRowCol - rowOrCol; i++)                   // Fills current Row to the Left
                {
                    nextNum++;
                    matrix[rowOrCol, limRowCol - i] = nextNum;
                }
               

                rowOrCol++;

                if (rowOrCol == limRowCol - rowOrCol)
                {
                    matrix[rowOrCol, rowOrCol] = ++nextNum;
                }
            } while (limRowCol > 2 * rowOrCol);

        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < size; j++)
            {
                Console.Write(Convert.ToString(matrix[i, j]).PadLeft(4, ' '));
            }
            Console.WriteLine();
        }
        
    }
}