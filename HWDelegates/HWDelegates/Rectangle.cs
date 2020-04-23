
namespace HWDelegates
{
    public class Rectangle : Figure
    {
        private double _sideA;
        private double _sideB;
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;

        }
        protected override FiguresNames NameF => FiguresNames.Rectangle;

       private double SideA { get=>_sideA; set { if (value > 0) _sideA = value; } }
       private double SideB { get => _sideB; set { if (value > 0) _sideB = value; } }
        public override string GetArea()
        {
            double area = SideA * SideB;
            return area.ToString();           
        }

        public override string ToString()
        {
            return $"rectangle with [side {SideA} & side {SideB}]";
        }

    }
}
