/*
Problem 3. Sequence n matrix
    • We are given a matrix of strings of size  N x M . Sequences in the matrix we define as sets of several neighbour elements located 
      on the same line, column or diagonal.
    • Write a program that finds the longest sequence of equal strings in the matrix.
Example:

    matrix            result              matrix              result

ha fifi ho hi                            s qq s    
fo ha hi xx         ha, ha, ha           pp pp s             s, s, s   
xxx ho ha xx                             pp qq s    

*/

using System;

class SequenceNMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of matrix rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter number of matrix colums: ");
        int M = int.Parse(Console.ReadLine());
        var matrix = new string[N, M];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter strings in row #{0}:", i);
            string[] line = Console.ReadLine().Split(new string[] { " ", ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = line[j];
            }
        }

        int maxLength = 1;
        int tempLength = 1;
        int maxRow = -1;
        int tempRow = -1;
        int maxCol = -1;
        int tempCol = -1;
        int sequenceType = 0;

#region rows

        for (int k = 0; k < N; k++)
        {
            for (int i = 0; i < M - 1; i++)
            {
                for (int j = i + 1; j < M; j++)
                {
                    if (matrix[k, i] == matrix[k, j])
                    {
                        tempLength++;
                        tempRow = k;
                        tempCol = i;
                        if (tempLength > maxLength)
                        {
                            sequenceType = 1;
                            maxLength = tempLength;
                            maxRow = tempRow;
                            maxCol = tempCol;
                        }
                    }
                    else
                    {
                        tempLength = 1;
                        break;
                    }
                }
                tempLength = 1;
            }
        }

#endregion        
        
#region cols
        for (int k = 0; k < M; k++)
        {
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (matrix[i, k] == matrix[j, k])
                    {
                        tempLength++;
                        tempRow = i;
                        tempCol = k;
                        if (tempLength > maxLength)
                        {
                            sequenceType = 2;
                            maxLength = tempLength;
                            maxRow = tempRow;
                            maxCol = tempCol;
                        }
                    }
                    else
                    {
                        tempLength = 1;
                        break;
                    }
                }
                tempLength = 1;
            }
        }
        

#endregion

#region diagDown

        for (int k = 0; k < N - 1; k++)
        {
            for (int i = 0; i < M - 1; i++)
            {
                for (int j = 1; j < (M - i > N - k ? N - k : M - i); j++)
                {
                    if (matrix[k, i] == matrix[k + j, i + j])
                    {
                        tempLength++;
                        tempRow = k;
                        tempCol = i;
                        if (tempLength > maxLength)
                        {
                            sequenceType = 3;
                            maxLength = tempLength;
                            maxRow = tempRow;
                            maxCol = tempCol;
                        }
                    }
                    else
                    {
                        tempLength = 1;
                        break;
                    }
                }
                tempLength = 1;
            }
        }

#endregion

#region diagUp

        for (int k = 1; k < N; k++)
        {
            for (int i = 0; i < M - 1; i++)
            {
                for (int j = 1; j < (M - i > k ? (k + 1) : M - i); j++)
                {
                    if (matrix[k, i] == matrix[k - j, i + j])
                    {
                        tempLength++;
                        tempRow = k;
                        tempCol = i;
                        if (tempLength > maxLength)
                        {
                            sequenceType = 4;
                            maxLength = tempLength;
                            maxRow = tempRow;
                            maxCol = tempCol;
                        }
                    }
                    else
                    {
                        tempLength = 1;
                        break;
                    }
                }
                tempLength = 1;
            }
        }

#endregion

        PrintResult(matrix, maxRow, maxCol, maxLength, sequenceType);
        
    }

    static void PrintResult(string[,] matrix, int maxRow, int maxCol, int maxLength, int sequenceType)
    {
        string type = "";
        switch (sequenceType)
        {
            case 1:
                type = "on one row.";
                break;
            case 2:
                type = "down a column.";
                break;
            case 3:
                type = "on a diagonal [row + x, col + x].";
                break;
            case 4:
                type = "on a diagonal [row - x, col + x].";
                break;
        }
        Console.WriteLine("The longest sequence goes " + type);
        Console.Write("It starts at [{0}, {1}]: ", maxRow, maxCol);
        for (int i = 0; i < maxLength; i++)
        {
            if (i != maxLength - 1)
            {
                Console.Write(matrix[maxRow, maxCol] + ", ");
            }
        }
        Console.WriteLine(matrix[maxRow, maxCol]);
    }
}