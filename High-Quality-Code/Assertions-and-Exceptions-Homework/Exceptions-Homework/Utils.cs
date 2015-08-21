namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Utils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("arr" + " cannot be null");
            }

            if (startIndex > arr.Length - 1 || startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("startIndex" + " cannot be less than 0 or greater than the last index");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count" + " cannot be a negative number. It is used as a subsequence length.");
            }

            if (startIndex + count > arr.Length)
            {
                throw new IndexOutOfRangeException("startIndex + count" + " must not exceed the length of the array");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str" + " cannot be null");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count" + " cannot be greater than the length of " + "str");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count" + " cannot be less than 0.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    Console.WriteLine("The number {0} is not prime.", number);
                    return false;
                }
            }

            Console.WriteLine("The number {0} is prime.", number);
            return true;
        }
    }
}