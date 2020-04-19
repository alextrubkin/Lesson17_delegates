using System;
using System.Collections.Generic;

namespace Homework_17
{
    // Delegate, which will return a string with area and perimeter
    //for an any figure inputed.
    public delegate string GetInfoDeleagate(IFigure figure);

    public class Program
    {
        private static void Main(string[] args)
        {
            // Dictionary instantiating.
            Dictionary<Enum, GetInfoDeleagate> figureDictionary = new Dictionary<Enum, GetInfoDeleagate>();


            // Creating deleagates to fulfill the dictionary's pairs (values).
            GetInfoDeleagate circleInfo = figure => $"Figure type: circle, " + figure.GetInfo();
            GetInfoDeleagate triangleInfo = figure => "Figure type: triangle, " + figure.GetInfo();
            GetInfoDeleagate squareInfo = figure => "Figure type: square, " + figure.GetInfo();
            GetInfoDeleagate rectangularInfo = figure => "Figure type: rectangular, " + figure.GetInfo();


            // Filling dictionary with key-value pairs.
            figureDictionary.Add(FigureType.Circle, circleInfo);
            figureDictionary.Add(FigureType.Triangle, triangleInfo);
            figureDictionary.Add(FigureType.Square, squareInfo);
            figureDictionary.Add(FigureType.Rectangular, rectangularInfo);


            // Instantiating some figures,
            // calculating and printing some areas and perimeters.
            Circle circle1 = new Circle(25);
            Console.WriteLine(figureDictionary[FigureType.Circle](circle1));

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(figureDictionary[FigureType.Triangle](triangle));

            Square square = new Square(56.308);
            Console.WriteLine(figureDictionary[FigureType.Square](square));

            Rectangular rectangular = new Rectangular(12.35, 856);
            Console.WriteLine(figureDictionary[FigureType.Rectangular](rectangular));

            Circle circle2 = new Circle(-1525);
            Console.WriteLine(figureDictionary[FigureType.Circle](circle2));

            Console.WriteLine("\nAny key to continue...");
            Console.ReadKey();


            // Another method :)
            Console.Clear();
            List<IFigure> figures = new List<IFigure>() { circle1, triangle, square, rectangular, circle2 };

            GetInfoDeleagate calc = figure => $"Figure type: {figure.GetType().Name}, " + figure.GetInfo();


            foreach (var item in figures)
            {
                if (item.GetInfo().Contains("not"))
                {
                    Console.WriteLine(item.GetType().Name + " " + item.GetInfo());
                }
                else
                {
                    Console.WriteLine(calc(item));
                }
            }

            Console.Write("\nAny key to quit...");

            Console.ReadKey();
        }
    }
}
