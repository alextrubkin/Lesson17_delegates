using System;

namespace DelegatesDictionary.Shapes
{
    public class Circle : Shape
    {
        private int _radius = 1;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override string Name => "Circle";

        public int Radius
        {
            get => _radius;
            set
            {
                if(value > 0) { _radius = value; }
            }
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
