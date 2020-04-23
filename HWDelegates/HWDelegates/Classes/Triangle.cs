
namespace HWDelegates
{
    public class Triangle : Figure
    {
        private double _height;
        private double _base;
        public Triangle(double a, double h)
        {
            Height = a;
            Base = h;
        }
        protected  override FiguresNames NameF => FiguresNames.Triangle;

        private double Height { get => _height; set { if (value > 0) _height = value; } }

        private double Base { get => _base; set { if (value > 0) _base = value; } }

        public override string GetArea()
        {
            double area = 0.5 * Height * Base;

            return area.ToString();
        }

        public override string ToString()
        {
            return $"triangle with [height {Height}\\ base {Base}]";
        }

    }
}
