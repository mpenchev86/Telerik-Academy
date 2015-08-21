using System;

namespace Point3D
{
    static class Distance
    {
        public static decimal CalculateDistance(Point3D p1, Point3D p2)
        {
            decimal distance = (decimal)Math.Sqrt(
                (p1.X - p2.X) * (p1.X - p2.X) +
                (p1.Y - p2.Y) * (p1.Y - p2.Y) +
                (p1.Z - p2.Z) * (p1.Z - p2.Z));
            return distance;
        }
    }
}
