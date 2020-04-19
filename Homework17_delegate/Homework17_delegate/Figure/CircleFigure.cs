using System;

namespace Homework17_delegate.Figure
{
    public class CircleFigure : BaseFigure
    {
        public CircleFigure(double radius)
        {
            Radius = radius;
            TypeOfFigure = TypeOfFigure.circle;

        }
        private double _count;
        public double Radius
        {
            get => _count;
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Incorrect, value must be>0");
                }
            }
        }
        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double GetPerimeter()
        {
            return (2 * Radius * Math.PI);
        }
    }

}