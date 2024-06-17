using GeometryLibrary.Shapes;

namespace GeometryTest
{
    public class TriangleTest
    {
        [Fact]
        public void RightTriangleAreaTest()
        {
            Triangle triangle = new(3,4,5);

            Assert.True(triangle.IsRightTriangle());
            Assert.Equal(6, triangle.Area);            
        }
        [Fact]
        public void TriangleNotExistTest()
        {
            Assert.Throws<ArgumentException>(() => { 
                Triangle triangle = new(3, 4, 9); 
            });         
        }
        [Fact]
        public void TriangleAreaTest()
        {
            Triangle triangle = new(13, 14, 15);

            Assert.False(triangle.IsRightTriangle());
            Assert.Equal(84, triangle.Area);
        }
        [Fact]
        public void RecalculateAreaTest()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.Equal(6, triangle.Area);
            triangle.A = 13;
            triangle.B = 14;
            triangle.C = 15;
            Assert.Equal(84, triangle.Area);
        }
    }
}