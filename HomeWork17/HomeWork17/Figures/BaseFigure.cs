
namespace HomeWork17.Figures
{
    public abstract class BaseFigure
    {
        public double Area { get; set; }
        public double Perimetr { get; set; }
        public abstract void GetArea();
        public abstract void GetPerimetr();
        public abstract TypeOfFigure TypeOfFigure { get; }
        public override string ToString()
        {
            return $"Area of {TypeOfFigure,10} is {Area,8}|\tPerimetr: {Perimetr,10}";
        }
    }
}
