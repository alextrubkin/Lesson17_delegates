using System;
using System.Collections.Generic;

namespace Geometric_figures
{
    public enum Figure
    {
        Circle,
        Square,
        Rectangle,
        Triangle
    }

    public delegate void Calculator(int paramA = 1, int paramB = 1, int paramС = 1);

    public class Program
    {
        public static void Main(string[] args)
        {
            var figures = new Dictionary<Figure, Calculator>();

            Calculator circle = (radius, paramB, paramС) => Console.WriteLine("Circle area = {0}", Math.PI * Math.Pow(radius, 2));
            circle += (radius, paramB, paramС) => Console.WriteLine("Circle perimeter = {0}", 2 * Math.PI * radius);

            Calculator square = (side, paramB, paramС) => Console.WriteLine("Square area = {0}", side * side);
            square += (side, paramB, paramС) => Console.WriteLine("Square perimeter = {0}", side * 4);

            Calculator rectangle = (sideA, sideB, paramС) => Console.WriteLine("Rectangle area = {0}", sideA * sideB);
            rectangle += (sideA, sideB, paramС) => Console.WriteLine("Rectangle perimeter = {0}", (sideA + sideB) * 2);

            Calculator triangle = (sideBase, height, sideC) => Console.WriteLine("Triangle area = {0}", sideBase * height / 2);
            triangle += (sideA, sideB, sideC) => Console.WriteLine("Triangle perimeter = {0}", sideA + sideB + sideC);

            figures.Add(Figure.Circle, circle);
            figures.Add(Figure.Square, square);
            figures.Add(Figure.Rectangle, rectangle);
            figures.Add(Figure.Triangle, triangle);

            figures[Figure.Circle].Invoke(5);
            figures[Figure.Square].Invoke(5);
            figures[Figure.Rectangle].Invoke(5, 8);
            figures[Figure.Triangle].Invoke(5, 8, 4);
        }
    }
}
