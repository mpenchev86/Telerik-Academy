namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    internal class SearchingAlgorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) 
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array doesn't exist");
            Debug.Assert(value != null, "The value to search for is null.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int len = arr.Length;
            Debug.Assert(len >= startIndex, "startIndex is out of range.");
            Debug.Assert(len >= endIndex, "endIndex is out of range.");
            Debug.Assert(startIndex < endIndex, "endIndex is out of range.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            bool arrayContainsValue = AssertionHelpers.CheckArrayForValue(arr, value);
            Debug.Assert(!arrayContainsValue, "Invalid return reached. The element exists in the array!");

            // Searched value not found
            return -1;
        }
    }
}
