namespace Abstraction
{
    using System;
    using System.Text;

    public abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("I am a {0}. ", this.GetType().Name);
            text.AppendFormat("My perimeter is {0:f2}. ", this.CalcPerimeter());
            text.AppendFormat("My surface is {0:f2}.", this.CalcSurface()).AppendLine();

            return text.ToString();
        }
    }
}
