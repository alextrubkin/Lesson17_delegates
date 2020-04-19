using Homework17_delegate.Figure;
using System;
using System.Collections.Generic;

namespace Homework17_delegate
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            var figure = new Dictionary<TypeOfFigure, MyDelegate>();

            var circle = new CircleFigure(5);
            var rectangle = new RectangleFigure(2, 4);
            var square = new SquareFigure(3);
            var triangle = new TriangleFigure(2, 4, 5);

            MyDelegate rectangleArea = () => { Console.WriteLine($"Rectangle area = {rectangle.GetArea()}"); };
            rectangleArea += () => { Console.WriteLine($"Rectangle perimeter = {rectangle.GetPerimeter()}"); };
            MyDelegate squareArea = () => { Console.WriteLine($"Square Area = {square.GetArea()}"); };
            squareArea += () => Console.WriteLine($"Square perimeter = {square.GetPerimeter()}");
            MyDelegate circleArea = () => { Console.WriteLine($"Circle Area = {circle.GetArea()}"); };
            circleArea += () => Console.WriteLine($"Circle perimeter = {circle.GetPerimeter()}");
            MyDelegate triangleArea = () => { Console.WriteLine($"Triangle Area = {triangle.GetArea()}"); };
            triangleArea += () => Console.WriteLine($"Triangle perimeter = {triangle.GetPerimeter()}");

            figure.Add(TypeOfFigure.circle, circleArea);
            figure.Add(TypeOfFigure.rectangle, rectangleArea);
            figure.Add(TypeOfFigure.square, squareArea);
            figure.Add(TypeOfFigure.triangle, triangleArea);

            figure[TypeOfFigure.circle]();
            figure[TypeOfFigure.rectangle]();
            figure[TypeOfFigure.square]();
            figure[TypeOfFigure.triangle]();

            Console.ReadKey();
        }
    }
}