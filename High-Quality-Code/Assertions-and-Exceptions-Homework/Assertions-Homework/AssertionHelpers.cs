namespace Assertions_Homework
{
    using System;

    internal class AssertionHelpers
    {
        public static bool CheckArrayForNullElement<T>(T[] arr) 
            where T : IComparable<T>
        {
            bool result = true;

            foreach (var element in arr)
            {
                if (element == null)
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool ValidateSorting<T>(T[] arr) 
            where T : IComparable<T>
        {
            bool result = true;

            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int currentComparedToNext = arr[i].CompareTo(arr[i + 1]);
                if (currentComparedToNext > 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool ValidateMinElementIndex<T>(T[] arr, int minIndex, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            for (int i = startIndex; i < endIndex + 1; i++)
            {
                if (arr[i].CompareTo(arr[minIndex]) < 0)
                {
                    return false;
                }
            }            

            return true;
        }

        public static bool CheckArrayForValue<T>(T[] arr, T value)
            where T : IComparable<T>
        {
            foreach (var element in arr)
            {
                if (element.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}