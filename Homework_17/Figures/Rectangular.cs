namespace Homework_17
{
    public class Rectangular : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }


        public Rectangular(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }


        public double GetArea()
        {
            return SideA * SideB;
        }

        public double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }

        public string GetInfo()
        {

            if (SideA <= 0 || SideB <= 0)
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
