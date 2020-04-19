using HomeWork17.Figures;
using System;
using System.Collections.Generic;

namespace HomeWork17
{
    public class Program
    {
        public delegate void DelegateCalculate();
        static void Main(string[] args)
        {
            Dictionary<BaseFigure, DelegateCalculate> calculation = new Dictionary<BaseFigure, DelegateCalculate>();

            var square = new Square(10);
            var circle = new Circle(12);
            var rectangle = new Rectangle(5, 10);
            var triangle = new Triangle(3, 5, 8,12);

            DelegateCalculate squareCalculate = square.GetArea;
            squareCalculate += square.GetPerimetr;

            DelegateCalculate circleCalculate = circle.GetArea;
            circleCalculate += circle.GetPerimetr;

            DelegateCalculate rectangleCalculate = rectangle.GetArea;
            rectangleCalculate += rectangle.GetPerimetr;

            DelegateCalculate triangleCalculate = triangle.GetArea;
            triangleCalculate += triangle.GetPerimetr;

            calculation.Add(square, squareCalculate);
            calculation.Add(circle, circleCalculate);
            calculation.Add(rectangle, rectangleCalculate);
            calculation.Add(triangle, triangleCalculate);

            calculation[square]();
            calculation[circle]();
            calculation[rectangle]();
            calculation[triangle]();

            Console.WriteLine(square.ToString());
            Console.WriteLine(circle.ToString());
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(triangle.ToString());

            Console.ReadKey();
        }
    }
}
