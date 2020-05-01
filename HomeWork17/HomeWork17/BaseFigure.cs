using System;


namespace HomeWork17
{
    
    public abstract class BaseFigure
    {
        protected abstract Figure Type { get; }
        public abstract double GetPerimeter();
        public abstract double GetArea();
        public override string ToString()
        {
            return $"{Type} has perimeter: {Math.Round(GetPerimeter(),2)} and area: {Math.Round(GetArea(),2)}\n";
        }
       
        
    }
}
