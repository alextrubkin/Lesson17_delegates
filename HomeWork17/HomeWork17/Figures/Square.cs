
namespace HomeWork17.Figures
{
    public class Square : BaseFigure
    {
        private double _height;
        public Square(double height)
        {
            Height = height;
        }
        public double Height
        {
            get => _height;
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        public override void GetArea()
        {
            Area = Height * Height;
        }

        public override void GetPerimetr()
        {
            Perimetr = Height * 4;
        }
        public override TypeOfFigure TypeOfFigure => TypeOfFigure.square;
    }
}
