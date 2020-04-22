using System;
using System.Collections.Generic;
using DelegatesDictionary.Shapes;

namespace DelegatesDictionary
{
    public class Program
    {
        delegate void ShapeInfo();

        public static void Main(string[] args)
        {
            Dictionary<Shape, ShapeInfo> dictionary = new Dictionary<Shape, ShapeInfo>();

            Circle circle = new Circle(3);
            ShapeInfo circleInfo = delegate { Console.WriteLine(circle); };

            Triangle triangle = new Triangle(4, 5, 4);
            ShapeInfo triangleInfo = delegate { Console.WriteLine(triangle); };

            Square square = new Square(6);
            ShapeInfo squareInfo = delegate { Console.WriteLine(square); };

            dictionary.Add(circle, circleInfo);
            dictionary.Add(triangle, triangleInfo);
            dictionary.Add(square, squareInfo);

            foreach(var pair in dictionary)
            {
                pair.Value();
            }
        }
    }
}
