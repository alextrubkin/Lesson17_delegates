namespace HWDelegates
{
    public abstract class Figure
    {
        protected abstract FiguresNames NameF { get;}
        public abstract string GetArea();
        public string PrintInfo()
        {
            return $"Area of {ToString()} is {GetArea()}";
        }

        
    }
}
