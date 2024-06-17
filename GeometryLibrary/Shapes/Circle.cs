namespace GeometryLibrary.Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException($"{nameof(Circle)} not exist");
            Radius = radius;
        }

        public double Radius { get; set; }

        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
