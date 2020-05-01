

namespace HomeWork17.Figures
{
    public class Rectangle : Square
    {
        private double _width = 1;
        public Rectangle(double height, double width) : base(height)
        {
            Width = width;
        }
        public double Width
        {
            get => _width;
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        protected override Figure Type => Figure.Rectangle;
        public override double GetArea()
        {
            return SideSize * Width;
        }
        public override double GetPerimeter()
        {
            return (SideSize + Width) * 2;
        }
    }
}
