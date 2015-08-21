namespace RefactorForLoop
{
    using System;

    public class RefactorForLoop
    {
        public static void Main(string[] args)
        {
            int[] numbersArray = new int[] { 1, 3, 4 };
            PrintArrayElementIfFound(numbersArray, 3);
        }

        public static void PrintArrayElementIfFound(int[] array, int expectedValue)
        {
            int arrayLength = array.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);

                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }
        }
    }
}
