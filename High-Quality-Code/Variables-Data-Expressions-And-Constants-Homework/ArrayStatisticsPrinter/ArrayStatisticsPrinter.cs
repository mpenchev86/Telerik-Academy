namespace ArrayStatisticsPrinter
{
    using System;

    public class ArrayStatisticsPrinter
    {
        public static void Main()
        {
            double[] newArray = new double[3] { 3, 7, 32 };
            int arrayLength = newArray.Length;
            PrintStatistics(newArray, arrayLength);
        }

        public static void PrintStatistics(double[] givenArray, int arrayLength)
        {
            var maxValueInArray = FindMax(givenArray, arrayLength);
            PrintMax(maxValueInArray);

            var minValueInArray = FindMin(givenArray, arrayLength);
            PrintMin(minValueInArray);

            var averageValueOfArray = FindAverage(givenArray, arrayLength);
            PrintAvg(averageValueOfArray);
        }
        
        public static double FindMin(double[] givenArray, int arrayLength)
        {
            double result = double.MaxValue;

            for (int i = 0; i < arrayLength; i++)
            {
                if (givenArray[i] < result)
                {
                    result = givenArray[i];
                }
            }

            return result;
        }

        public static double FindMax(double[] givenArray, int arrayLength)
        {
            double result = double.MinValue;

            for (int i = 0; i < arrayLength; i++)
            {
                if (givenArray[i] > result)
                {
                    result = givenArray[i];
                }
            }

            return result;
        }

        public static double FindAverage(double[] givenArray, double arrayLength)
        {
            double sumOfElements = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                sumOfElements += givenArray[i];
            }

            double result = sumOfElements / arrayLength;
            return result;
        }
        
        public static void PrintMax(double max)
        {
            Console.WriteLine("Maximal value is: {0}", max);
        }

        public static void PrintMin(double min)
        {
            Console.WriteLine("Minimal value is: {0}", min);
        }

        public static void PrintAvg(double average)
        {
            Console.WriteLine("Average value is: {0}", average);
        }
    }
}
