using System;

namespace HWDelegates
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double r)
        {
            Radius = r;
        }
        protected override FiguresNames NameF => FiguresNames.Circle;
        public double Radius
        {
            get => _radius;
            set
            {

                if (value > 0)
                {
                    _radius = value;
                }
            }
        }

       public override string GetArea()
        {
            double area = Math.Round( Math.PI * Math.Pow(Radius, 2),3);
            double length = Math.Round(2 * Math.PI * Radius,3);           
            return $"{area.ToString()}|Length: {length.ToString()}";
        }

        //public static string GetStaticArea(Circle circle)
        //{
        //    double Radius=default;
        //    double area = Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
        //    double length = Math.Round(2 * Math.PI * Radius, 3);            
        //   return area.ToString() + " | " + length.ToString();
        //}

        public override string ToString()
        {
            return $"circle with radius {Radius}";
        }



    }
}
