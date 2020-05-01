using System;


namespace HomeWork17.Figures
{
    public class EquilateralTriangle : BaseFigure
    {
        private double _sideSize = 1;
        public EquilateralTriangle(double sideSize)
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
        protected override Figure Type => Figure.Triangle;
        public override double GetPerimeter()
        {
            return SideSize * 3;
        }
        public override double GetArea()
        {
            return (Math.Pow(SideSize,2)*Math.Sqrt(3))/4;
        }
    }
}
