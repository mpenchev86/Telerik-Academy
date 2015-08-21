namespace Kitchen
{
    using System;

    public class Vegetable
    {
        public Vegetable()
        {
        }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }
        
        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        internal void Cut()
        {
            this.IsCut = true;
        }

        internal void Peel()
        {
            this.IsPeeled = true;
        }

        internal void Cook()
        {
            this.IsCooked = true;
        }
    }
}
