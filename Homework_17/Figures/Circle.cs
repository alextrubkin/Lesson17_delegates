using System;

namespace Homework_17
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }


        public Circle(double radius)
        {
            Radius = radius;
        }


        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public string GetInfo()
        {
            if (Radius <= 0)
            {
                return "does not exists.";
            }
            else
            {
                return $"area: {GetArea():f2}, perimeter: {GetPerimeter():f2}";
            }
        }
    }
}
