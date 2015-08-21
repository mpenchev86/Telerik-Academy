/*
Problem 5. Sort by string length
    • You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters 
      composing them).
*/

using System;

class SortByStringLength
{
    static void Main(string[] args)
    {
        Console.Write("Enter string array length: ");
        int length = int.Parse(Console.ReadLine());
        string[] array = new string[length];
        Console.WriteLine("Enter strings:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
        
        int[] stringSizes = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            stringSizes[i] = array[i].Length;
        }

        SortArrays(array, stringSizes, 0, array.Length - 1);

        Console.WriteLine("Strings by length:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static void SortArrays(string[] array, int[] stringSizes, int startIndex, int endIndex)
    {
        int tempNum;
        string tempString;                                     
        int indexSmaller = startIndex;                                  
        for (int i = startIndex; i < endIndex; i++)                     
        {
            if (stringSizes[i] <= stringSizes[endIndex])              
            {
                tempNum = stringSizes[indexSmaller];
                stringSizes[indexSmaller] = stringSizes[i];
                stringSizes[i] = tempNum;

                tempString = array[indexSmaller];
                array[indexSmaller] = array[i];
                array[i] = tempString;

                indexSmaller++;
            }
        }
        tempNum = stringSizes[indexSmaller];                           
        stringSizes[indexSmaller] = stringSizes[endIndex];
        stringSizes[endIndex] = tempNum;

        tempString = array[indexSmaller];
        array[indexSmaller] = array[endIndex];
        array[endIndex] = tempString;

        if (startIndex < indexSmaller - 1)                              
        {
            SortArrays(array, stringSizes, startIndex, indexSmaller - 1);
        }
        if (indexSmaller + 1 < endIndex)                                
        {
            SortArrays(array, stringSizes, indexSmaller + 1, endIndex);
        }
    }
}