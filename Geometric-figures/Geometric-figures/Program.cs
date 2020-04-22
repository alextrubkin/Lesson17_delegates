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

    public delegate Calculator Functional(Calculator delegate1, Calculator delegate2);
    public delegate string Calculator(int paramA = 1, int paramB = 1, int paramС = 1);

    public class Program
    {
        public static void Main(string[] args)
        {
            var figures = new Dictionary<Figure, Calculator>();

            Calculator circleArea = (radius, paramB, paramС) => $"Circle area = {Math.PI * Math.Pow(radius, 2)}\n";
            Calculator circlePerimeter = (radius, paramB, paramС) => $"Circle perimeter = {2 * Math.PI * radius}\n";

            Calculator squareArea = (side, paramB, paramС) => $"Square area = {side * side}\n";
            Calculator squarePerimeter = (side, paramB, paramС) => $"Square perimeter = {side * 4}\n";

            Calculator rectangleArea = (sideA, sideB, paramС) => $"Rectangle area = {sideA * sideB}\n";
            Calculator rectanglePerimeter = (sideA, sideB, paramС) => $"Rectangle perimeter = {(sideA + sideB) * 2}\n";

            Calculator triangleArea = (sideBase, height, sideC) => $"Triangle area = {sideBase * height / 2}\n";
            Calculator trianglePerimeter = (sideA, sideB, sideC) => $"Triangle perimeter = {sideA + sideB + sideC}\n";
            
            Functional add = (d1, d2) => (paramA, paramB, paramС) => d1.Invoke(paramA, paramB, paramС) + d2.Invoke(paramA, paramB, paramС);

            figures.Add(Figure.Circle, add(circleArea, circlePerimeter));
            figures.Add(Figure.Square, add(squareArea, squarePerimeter));
            figures.Add(Figure.Rectangle, add(rectangleArea, rectanglePerimeter));
            figures.Add(Figure.Triangle, add(triangleArea, trianglePerimeter));
            
            // Сonsole output
            
            Console.WriteLine($"{new string('-', 20)} Variant #1 {new string('-', 20)}\n");
            
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Value(2, 3, 4));
            }

            Console.WriteLine($"{new string('-', 20)} Variant #2 {new string('-', 20)}\n");

            Console.WriteLine(figures[Figure.Circle].Invoke(5));
            Console.WriteLine(figures[Figure.Square].Invoke(5));
            Console.WriteLine(figures[Figure.Rectangle].Invoke(5, 8));
            Console.WriteLine(figures[Figure.Triangle].Invoke(5, 8, 4));
            
            Console.ReadKey();
        }
    }
}
