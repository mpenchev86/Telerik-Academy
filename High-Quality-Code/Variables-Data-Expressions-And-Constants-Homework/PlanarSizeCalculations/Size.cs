namespace PlanarSizeCalculations
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public static double GetRotatedDimensions(double angle, double firstDimension, double secondDimension)
        {
            double dimensionWithSine = Math.Abs(Math.Sin(angle)) * secondDimension;
            double dimensionWithCosine = Math.Abs(Math.Cos(angle)) * firstDimension;

            return dimensionWithSine + dimensionWithCosine;
        }

        public Size GetRotatedSize(double rotationAngle)
        {
            double widthAfterRotation = GetRotatedDimensions(rotationAngle, this.Width, this.Height);
            double heightAfterRotation = GetRotatedDimensions(rotationAngle, this.Height, this.Width);
            Size result = new Size(widthAfterRotation, heightAfterRotation);

            return result;
        }
    }
}
