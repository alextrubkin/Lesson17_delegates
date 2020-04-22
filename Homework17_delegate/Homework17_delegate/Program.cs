using System;
using System.Collections.Generic;

namespace Homework17_delegate
{
    public delegate MyDelegate DelegateFigure(MyDelegate area, MyDelegate perimeter);
    public delegate string MyDelegate(double aParameter, double bParameter, double cParameter);
    
    public class Program
    { 
        public static void Main(string[] args)
        {
            var figure = new Dictionary<TypeOfFigure, DelegateFigure>();

            MyDelegate rectangleArea = (aSide, bSide, cParameter) => { return $"{aSide * bSide}"; };
            MyDelegate rectanglePerimeter = (aSide, bSide, cParameter) => { return $"{(aSide + bSide) * 2}"; };
            MyDelegate squareArea = (aSide, bParameter, cParameter) => { return $"{Math.Pow(aSide, 2)}"; };
            MyDelegate squarePerimeter = (aSide, bParameter, cParameter) => { return $"{4 * aSide}"; };
            MyDelegate circleArea = (radius, bParameter, cParameter) => { return $"{(Math.Pow(radius, 2) * Math.PI):F2}"; };
            MyDelegate circlePerimeter = (radius, bParameter, cParameter) => { return $"{(2 * radius * Math.PI):F2}"; };
            MyDelegate triangleArea = (aSide, bSide, cSide) => { return $"{Math.Sqrt(((aSide + bSide + cSide) / 2) * (((aSide + bSide + cSide) / 2) - aSide) * (((aSide + bSide + cSide) / 2) - bSide) * (((aSide + bSide + cSide) / 2) - cSide))}";};
            MyDelegate trianglePerimeter = (aSide, bSide, cSide) => { return $"{aSide + bSide + cSide}"; };


            DelegateFigure rectangle =(MyDelegate rectangleArea,MyDelegate rectanglePerimeter) => (aParameter, bParameter, cParameter) => { return $"Area = {rectangleArea.Invoke(aParameter, bParameter, cParameter)} Perimeter = {rectanglePerimeter.Invoke(aParameter, bParameter, cParameter)}"; }; 
            DelegateFigure circle = (MyDelegate circleArea, MyDelegate circlePerimeter) => (aParameter, bParameter, cParameter) => { return $"Area = {circleArea.Invoke(aParameter, bParameter, cParameter)} Perimeter = {circlePerimeter.Invoke(aParameter, bParameter, cParameter)}"; };
            DelegateFigure triangle = (MyDelegate triangleArea, MyDelegate trianglePerimeter) => (aParameter, bParameter, cParameter) => { return $"Area = {triangleArea.Invoke(aParameter, bParameter, cParameter)} Perimeter = {trianglePerimeter.Invoke(aParameter, bParameter, cParameter)}"; };
            DelegateFigure square = (MyDelegate squareArea, MyDelegate squarePerimeter) => (aParameter, bParameter, cParameter) => { return $"Area = {squareArea.Invoke(aParameter, bParameter, cParameter)} Perimeter = {squarePerimeter.Invoke(aParameter, bParameter, cParameter)}"; };


            figure.Add(TypeOfFigure.circle, circle);
            figure.Add(TypeOfFigure.rectangle, rectangle);
            figure.Add(TypeOfFigure.square, square);
            figure.Add(TypeOfFigure.triangle, triangle);

            figure[TypeOfFigure.circle].Invoke(circleArea, circlePerimeter);
            figure[TypeOfFigure.rectangle].Invoke(rectangleArea, rectanglePerimeter);
            figure[TypeOfFigure.square].Invoke(squareArea, squarePerimeter);
            figure[TypeOfFigure.triangle].Invoke(triangleArea, trianglePerimeter);

            Console.WriteLine($"Rectangle: {figure[TypeOfFigure.rectangle].Invoke(rectangleArea, rectanglePerimeter).Invoke(3,4,0)}");
            Console.WriteLine($"Circle: {figure[TypeOfFigure.circle].Invoke(circleArea, circlePerimeter).Invoke(5, 0, 0)}");
            Console.WriteLine($"Square: {figure[TypeOfFigure.square].Invoke(squareArea, squarePerimeter).Invoke(3, 0, 0)}");
            Console.WriteLine($"Triangle: {figure[TypeOfFigure.triangle].Invoke(triangleArea, trianglePerimeter).Invoke(3, 4, 5)}");

            Console.ReadKey();
        }
    }
}