namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    internal class SortingAlgorithms
    {
        public static void SelectionSort<T>(T[] arr) 
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array doesn't exist");
            bool elementOfArrIsNull = AssertionHelpers.CheckArrayForNullElement(arr);
            Debug.Assert(elementOfArrIsNull, "At least one element of 'arr' is null");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            bool isSorted = AssertionHelpers.ValidateSorting(arr);
            Debug.Assert(isSorted, "Sorting failed.");
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int len = arr.Length;
            Debug.Assert(len >= startIndex, "startIndex is out of range.");
            Debug.Assert(len >= endIndex, "endIndex is out of range.");
            Debug.Assert(startIndex < endIndex, "endIndex is out of range.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            bool isMinElementIndex = AssertionHelpers.ValidateMinElementIndex(arr, minElementIndex, startIndex, endIndex);
            Debug.Assert(isMinElementIndex, "minElementIndex is not the index of the minimum element.");
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
