using System;

namespace HWDelegates
{
    public class Square : Figure
    {
        private double _side;

        public Square(double side)
        {
            Side = side;
        }
        protected override FiguresNames NameF => FiguresNames.Square;
        private double Side { get => _side; set { if (value > 0) _side = value; } }
        public override string GetArea()
        {
            double area = Math.Pow(Side, 2);
            return area.ToString();
        }

        public override string ToString()
        {
            return $"square with side {Side}";
        }
    }
}
