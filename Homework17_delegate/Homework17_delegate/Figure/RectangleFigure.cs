using System;

namespace Homework17_delegate.Figure
{
    public class RectangleFigure : BaseFigure
    {
        public RectangleFigure(double aSide, double bSide)
        {
            TypeOfFigure = TypeOfFigure.rectangle;
            ASide = aSide;
            BSide = bSide;
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
        protected double BSide
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
            return ASide * BSide;
        }

        public override double GetPerimeter()
        {
            return (ASide + BSide) * 2;
        }
    }
}