using System;


namespace HomeWork17.Figures
{
    public class Circle : BaseFigure
    {
        private double _radius = 1;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
            }
        }
        protected override Figure Type => Figure.Circle;

        public override double GetPerimeter()
        {
            return Math.Pow(Radius, 2);
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return base.ToString()+ $"and circumference {GetCircumference()}\n";
        }
    }
}
