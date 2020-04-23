using System;
using System.Collections.Generic;

namespace HWDelegates
{
    class Program
    {
        public delegate string MyDelegate(Figure figure);      
        public static void PrintInfo(double area, double length=0)
        {
            if(length==0)
            {
                Console.WriteLine($"Area is {area}");
            }
            else
            Console.WriteLine($"Area is {area}| length is {length}");
        }        

        static void Main(string[] args)
        {
            double area = default;
            double length=default;

            Action<int,int> actionCircleDlgt = delegate (int radius, int zero ) { area = Math.Round(Math.PI * Math.Pow(radius, 2), 2); };
            actionCircleDlgt += (int radius, int zero) => { length =Math.Round ((2 * Math.PI * radius),2); };
            Action<int, int> actionRectangleDlgt = delegate (int sideA, int sideB) { area = sideA * sideB; };
            Action<int, int> actionTriangleDlgt = delegate (int hight, int baseF) { area = hight * baseF; };
            Action<int, int> actionSquareDlgt = delegate (int side, int zero) { area = side * side; };


            Dictionary<FiguresNames, Action<int, int>> simpleDictionary = new Dictionary<FiguresNames, Action<int, int>>();

            simpleDictionary.Add(FiguresNames.Circle, actionCircleDlgt);
            simpleDictionary.Add(FiguresNames.Rectangle, actionRectangleDlgt);
            simpleDictionary.Add(FiguresNames.Triangle, actionTriangleDlgt);
            simpleDictionary.Add(FiguresNames.Square, actionSquareDlgt);

            simpleDictionary[FiguresNames.Circle](1,48);           
            PrintInfo(area, length);
            simpleDictionary[FiguresNames.Square](8, 0); 
            PrintInfo(area);

            //===============================================================================================================
            MyDelegate myDelegCircleArea = figure => figure.PrintInfo();//$"Area of {figure.ToString()} is {figure.GetArea()}";
            MyDelegate myDelegTriangleArea = figure => figure.PrintInfo();
            MyDelegate myDelegRectangleArea = figure => figure.PrintInfo();

            Dictionary<FiguresNames, MyDelegate> keyWithFormula = new Dictionary<FiguresNames, MyDelegate>();

            keyWithFormula.Add(FiguresNames.Circle, myDelegCircleArea);
            keyWithFormula.Add(FiguresNames.Triangle, myDelegTriangleArea);
            keyWithFormula.Add(FiguresNames.Rectangle, myDelegRectangleArea);
            keyWithFormula.Add(FiguresNames.Square, delegate (Figure figure) { return figure.PrintInfo(); });


            Console.WriteLine(keyWithFormula[FiguresNames.Circle](new Circle(18.2)));
            Console.WriteLine(keyWithFormula[FiguresNames.Rectangle](new Rectangle(6, 7.25)));
            Console.WriteLine(keyWithFormula[FiguresNames.Square](new Square(27.25)));
            Console.WriteLine(keyWithFormula[FiguresNames.Triangle](new Triangle(18, 15.76)));

            Console.WriteLine("\n\n");
            Console.WriteLine("Dictionary with Func<>Delegate:");
            Dictionary<FiguresNames, Func<Figure, string>> myDictionary = new Dictionary<FiguresNames, Func<Figure, string>>();
            Func<Figure, string> circleFuncDelegate = figure => $"Area of {figure.ToString()} is {figure.GetArea()}";
            Func<Figure, string> squareFuncDelegate = figure => $"Area of {figure.ToString()} is {figure.GetArea()}";
            Func<Figure, string> rectangleFuncDelegate = figure => $"Area of {figure.ToString()} is {figure.GetArea()}";
            Func<Figure, string> triangleFuncDelegate = figure => $"Area of {figure.ToString()} is {figure.GetArea()}";
            myDictionary.Add(FiguresNames.Circle, circleFuncDelegate);
            myDictionary.Add(FiguresNames.Square, squareFuncDelegate);
            myDictionary.Add(FiguresNames.Rectangle, rectangleFuncDelegate);
            myDictionary.Add(FiguresNames.Triangle, triangleFuncDelegate);
            
            Console.WriteLine("Input Type of figure (1-circle, 2-square, 3- rectangle, 4-triangle) :");
            if (int.TryParse(Console.ReadLine(), out int numberOfFigure))
            {
                if (Enum.IsDefined(typeof(FiguresNames), numberOfFigure))
                {
                    switch (numberOfFigure)
                    {
                        case 1:
                            Console.WriteLine("Input radius:");
                            double.TryParse(Console.ReadLine(), out double radius1);
                            Circle circle2 = new Circle(radius1);
                            Console.WriteLine(myDictionary[FiguresNames.Circle](circle2));

                            break;

                        case 2:
                            Console.WriteLine("Input side:");
                            double.TryParse(Console.ReadLine(), out double side1);
                            Square square2 = new Square(side1);
                            Console.WriteLine(myDictionary[FiguresNames.Square](square2));
                            break;

                        case 3:
                            Console.WriteLine("Input side A:");
                            double.TryParse(Console.ReadLine(), out double sideA);

                            Console.WriteLine("Input side B:");
                            double.TryParse(Console.ReadLine(), out double sideB);
                            Rectangle rectangle2 = new Rectangle(sideA, sideB);
                            Console.WriteLine(myDictionary[FiguresNames.Rectangle](rectangle2));
                            break;

                        case 4:
                            Console.WriteLine("Input height:");
                            double.TryParse(Console.ReadLine(), out double height);
                            Console.WriteLine("Input base:");
                            double.TryParse(Console.ReadLine(), out double baseT);
                            Triangle triangle2 = new Triangle(height, baseT);
                            Console.WriteLine(myDictionary[FiguresNames.Rectangle](triangle2));
                            break;
                    }
                }
                else
                    Console.WriteLine("Your choice is wrong!");
            }
                    
        }           

    }
}
