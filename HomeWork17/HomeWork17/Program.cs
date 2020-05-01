using System;
using System.Collections.Generic;
using HomeWork17.Figures;

namespace HomeWork17
{
    public delegate void MyDelegate();

    public class Program
    {

        static void Main(string[] args)
        {


            Dictionary<Figure, MyDelegate> figureDictionary = new Dictionary<Figure, MyDelegate>();

            Console.WriteLine("Enter A parametr:");
            double paramA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B parametr:");
            double paramB = double.Parse(Console.ReadLine());

            var square = new Square(paramA);
            var circle = new Circle(paramA);
            var rectangle = new Rectangle(paramA, paramB);
            var triangle = new EquilateralTriangle(paramA);
            int i;

            Console.Write("Menu:\n1) View Circle info \n2) View Square info \n3) View Rectangle info \n4) View equilateral triangle info \n5) Exit\n");

            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    MyDelegate circleInfo = delegate { Console.WriteLine(circle.ToString()); };
                    figureDictionary.Add(Figure.Circle, circleInfo);
                    figureDictionary[Figure.Circle]();
                    break;
                case 2:
                    MyDelegate squareInfo = delegate { Console.WriteLine(square.ToString()); };
                    figureDictionary.Add(Figure.Square, squareInfo);
                    figureDictionary[Figure.Square]();
                    break;
                case 3:
                    MyDelegate rectangleInfo = delegate { Console.WriteLine(rectangle.ToString()); };
                    figureDictionary.Add(Figure.Rectangle, rectangleInfo);
                    figureDictionary[Figure.Rectangle]();
                    break;
                case 4:
                    MyDelegate triangleInfo = delegate { Console.WriteLine(triangle.ToString()); };
                    figureDictionary.Add(Figure.Triangle, triangleInfo);
                    figureDictionary[Figure.Triangle]();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("You entered something else...");
                    break;
            }
                                 
            Console.ReadKey();
        }
      
    }
}


