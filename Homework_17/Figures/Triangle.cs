using System;
using System.Collections.Generic;

namespace Homework_17
{
    public class Triangle : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }


        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }


        public double GetArea()
        {
            double halfPer = GetPerimeter() / 2;
            return Math.Sqrt(halfPer * (halfPer - SideA) * (halfPer - SideB) * (halfPer - SideC));
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public string GetInfo()
        {
            List<double> sidesList = new List<double> { SideA, SideB, SideC };
            sidesList.Sort();

            if (sidesList[0] + sidesList[1] <= sidesList[2])
            {
                return "does not exists.";
            }
            else
            {
                return $"area: {GetArea():f2}, perimeter: {GetPerimeter():f2}";
            }
        }
    }
}

