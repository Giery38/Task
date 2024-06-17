namespace GeometryLibrary.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            if (a > b + c || b > a + c || c > a + b)
            {
                throw new ArgumentException($"{nameof(Triangle)} not exist");
            }
            
            A = a;
            B = b;
            C = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        protected override double CalculateArea()
        {
            if (IsRightTriangle())
            {
                return (A * B) / 2;
            }                
            
            double p = (A+B+C)/2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsRightTriangle() 
        {
            return C*C == A*A + B*B;
        }
    }
}
