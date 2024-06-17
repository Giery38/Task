namespace GeometryLibrary.Shapes
{
    public abstract class Shape : IShape
    {
        public virtual double Area { get => CalculateArea(); }

        protected abstract double CalculateArea();

        double IShape.CalculateArea()
        {
            return CalculateArea();
        }
    }
}
