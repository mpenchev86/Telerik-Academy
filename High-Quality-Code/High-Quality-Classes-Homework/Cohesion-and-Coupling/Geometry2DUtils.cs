﻿namespace CohesionAndCoupling
{
    using System;

    public static class Geometry2DUtils
    {
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}
