using System;

namespace Homework17_delegate.Figure
{
    public class SquareFigure : BaseFigure
    {
        public SquareFigure(double aSide)
        {
            TypeOfFigure = TypeOfFigure.square;
            ASide = aSide;
        }
        private double _count;
        protected double ASide
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
            return Math.Pow(ASide, 2);
        }

        public override double GetPerimeter()
        {
            return 4 * ASide;
        }
    }
}