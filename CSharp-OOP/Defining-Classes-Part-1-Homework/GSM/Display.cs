using System;

namespace Phone
{
    internal class Display
    {
#region fields
        private double size;
        private int numberOfColors;
#endregion

#region constructors
        public Display(double size)
            :this(size, 0)
        {
            this.size = size;
        }

        public Display(double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
#endregion

#region properties
        public double Siza
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                if (this.numberOfColors <= 0)
                {
                    throw new NullReferenceException();
                }

                return this.numberOfColors;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.numberOfColors = value;
            }
        }

#endregion

#region methods
        
#endregion
        
    }
}
