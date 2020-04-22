namespace DelegatesDictionary.Shapes
{
    public class Square : Shape
    {
        private int _side = 1;

        public Square(int side)
        {
            Side = side;
        }

        public override string Name => "Square";

        public int Side
        {
            get => _side;
            set
            {
                if(value > 0) { _side = value; }
            }
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return Side * 4;
        }
    }
}
