using System;

namespace HomeWork17.Figures
{
    public class Circle : BaseFigure
    {
        private double _radius;
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

        public override void GetArea()
        {
            Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public override void GetPerimetr()
        {
            Perimetr = Math.Round(2 * Math.PI * Radius, 2);
        }
        public override TypeOfFigure TypeOfFigure => TypeOfFigure.circle;
    }
}
