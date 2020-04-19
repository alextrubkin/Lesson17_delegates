
namespace HomeWork17.Figures
{
    public class Triangle : Square
    {
        private double _triangleBase;
        private double _leftSide;
        private double _rightSide;
        public Triangle(double triangleBase, double leftSide, double rightSide, double height):base(height)
        {
            TriangleBase = triangleBase;
            LeftSide = leftSide;
            RightSide = rightSide;
        }

        public double TriangleBase
        {
            get => _triangleBase;
            set
            {
                if (value > 0)
                {
                    _triangleBase = value;
                }
            }
        }

        public double LeftSide
        {
            get => _leftSide;
            set
            {
                if (value > 0)
                {
                    _leftSide = value;
                }
            }
        }

        public double RightSide
        {
            get => _rightSide;
            set
            {
                if (value > 0)
                {
                    _rightSide = value;
                }
            }
        }

        public override TypeOfFigure TypeOfFigure => TypeOfFigure.triangle;
        public override void GetArea()
        {
            Area = TriangleBase * Height / 2;
        }

        public override void GetPerimetr()
        {
            Perimetr = TriangleBase + LeftSide + RightSide;
        }
    }
}
