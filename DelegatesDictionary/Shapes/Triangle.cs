using System;

namespace DelegatesDictionary.Shapes
{
    public class Triangle : Shape
    {
        private int _sideA = 1;
        private int _sideB = 1;
        private int _sideC = 1;

        public Triangle(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override string Name => "Triangle";

        public int SideA
        {
            get => _sideA;
            set
            {
                if(value > 0) { _sideA = value; }
            }
        }

        public int SideB
        {
            get => _sideB;
            set
            {
                if (value > 0) { _sideB = value; }
            }
        }

        public int SideC
        {
            get => _sideC;
            set
            {
                if (value > 0) { _sideC = value; }
            }
        }

        public override double GetArea()
        {
            double halfPerim = GetPerimeter()/2;

            double area = Math.Sqrt(halfPerim * (halfPerim - SideA) * (halfPerim - SideB) * (halfPerim - SideC));

            return area;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
