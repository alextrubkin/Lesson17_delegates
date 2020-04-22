namespace DelegatesDictionary.Shapes
{
    public abstract class Shape
    {
        public abstract string Name { get; }

        public abstract double GetPerimeter();

        public abstract double GetArea();

        public override string ToString()
        {
            return $"{Name} where perimeter = {GetPerimeter()} and area = {GetArea()}";
        }
    }
}
