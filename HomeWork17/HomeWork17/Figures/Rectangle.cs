
namespace HomeWork17.Figures
{
    public class Rectangle : Square
    {
        private double _width;
        public Rectangle(double height, double width) : base(height)
        {
            Height = height;
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
        public override TypeOfFigure TypeOfFigure => TypeOfFigure.rectangle;
        public override void GetArea()
        {
            Area = Height * Width;
        }

        public override void GetPerimetr()
        {
            Perimetr = 2 * Height + 2 * Width;
        }
    }
}
