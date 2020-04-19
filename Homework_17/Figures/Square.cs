namespace Homework_17
{
    public class Square : IFigure
    {
        public double SideA { get; private set; }

        public Square(double sideA)
        {
            SideA = sideA;
        }

        public double GetArea()
        {
            return SideA * SideA;
        }

        public double GetPerimeter()
        {
            return SideA * 4;
        }

        public string GetInfo()
        {

            if (SideA <= 0)
            {
                return "does not exists.";
            }
            else
            {
                return $"area: {GetArea():f2}, perimeter: {GetPerimeter():f2}";
            }
        }
    }
}
