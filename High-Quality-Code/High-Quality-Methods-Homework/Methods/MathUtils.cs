namespace Methods
{
    using System;

    public class MathUtils
    {
        public static double CalcTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));
            return area;
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("At least one number should be passed as an argument to the method.");
            }

            int maxValue = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        public static double CalcDistanceBetweenPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double horizontalVectorSquare = firstPointX - secondPointX;
            double verticalVectorSquare = firstPointY - secondPointY;

            double distance = Math.Sqrt(horizontalVectorSquare + verticalVectorSquare);
            return distance;
        }

        public static string GetLinePositionIn2D(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            string result = string.Empty;
            if (firstPointX == secondPointX && firstPointY == secondPointY)
            {
                result = "The two points have identical coordinates.";
            }
            else if (firstPointX == secondPointX)
            {
                result = "The line is perpendicular to the horizontal axis.";
            }
            else if (firstPointY == secondPointY)
            {
                result = "The line is parallel to the horizontal axis.";
            }
            else
            {
                result = "The line is not parallel to eather axis.";
            }

            return result;
        }
    }
}
