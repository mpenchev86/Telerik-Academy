namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Geometry2DUtils.CalcDistance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Geometry3DUtils.CalcDistance(5, 2, -1, 3, -6, 4));

            var parallelepiped = new Parallelepiped(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalcVolume());
            var diagonalXYZ = Geometry3DUtils.CalcDistance(0, 0, 0, parallelepiped.Width, parallelepiped.Height, parallelepiped.Depth);
            Console.WriteLine("Diagonal XYZ = {0:f2}", diagonalXYZ);
            var diagonalXY = Geometry2DUtils.CalcDistance(0, parallelepiped.Width, 0, parallelepiped.Height);
            Console.WriteLine("Diagonal XY = {0:f2}", diagonalXY);
            var diagonalXZ = Geometry2DUtils.CalcDistance(0, parallelepiped.Width, 0, parallelepiped.Depth);
            Console.WriteLine("Diagonal XZ = {0:f2}", diagonalXZ);
            var diagonalYZ = Geometry2DUtils.CalcDistance(0, parallelepiped.Height, 0, parallelepiped.Depth);
            Console.WriteLine("Diagonal YZ = {0:f2}", diagonalYZ);
        }
    }
}