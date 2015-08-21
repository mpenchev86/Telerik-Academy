namespace PlanarSizeCalculations
{
    using System;

    public class PlanarSizeCalculations
    {
        public static void Main()
        {
            var figure = new Size(4.4, 7.2);
            var sizeAfterRotation = figure.GetRotatedSize(55.2);

            Console.WriteLine("Initial size:\n width : {0}\n height : {1}", figure.Width, figure.Height);
            Console.WriteLine("Size after rotation:\n width : {0}\n height : {1}", sizeAfterRotation.Width, sizeAfterRotation.Height);
        }
    }
}