using System;

namespace HomeWork17.Figures
{
    public class Square:BaseFigure
    {
        private double _sideSize = 1;
        public Square(double sideSize)
        {
            SideSize = sideSize;
        }
        public double SideSize
        {
            get => _sideSize;
            set
            {
                if (value > 0)
                {
                    _sideSize = value;
                }
            }
        }
        protected override Figure Type => Figure.Square;
        public override double GetPerimeter()
        {
            return SideSize * 4;
        }
        public override double GetArea()
        {
            return Math.Pow(SideSize, 2);
        }
        
    }
}
