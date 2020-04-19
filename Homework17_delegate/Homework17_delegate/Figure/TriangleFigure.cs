using System;

namespace Homework17_delegate.Figure
{
    public class TriangleFigure : BaseFigure
    {
        public TriangleFigure(double aSide, double bSide, double cSide)
        {
            TypeOfFigure = TypeOfFigure.circle;
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
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
        protected double CSide
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
            var p = (ASide + BSide + CSide) / 2;
            var area = Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
            return area;
        }

        public override double GetPerimeter()
        {
            return ASide + BSide + CSide;
        }
    }
}