namespace Homework17_delegate.Figure
{
    public abstract class BaseFigure
    {
        public BaseFigure()
        {
        }
        public TypeOfFigure TypeOfFigure { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return this.ToString();
        }
    }
}