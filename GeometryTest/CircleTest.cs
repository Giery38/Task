using GeometryLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest
{
    public class CircleTest
    {
        [Fact]
        public void CircleAreaTest()
        {
            Circle circle = new(1);
            Assert.Equal(Math.PI, circle.Area);
        }

        [Fact]
        public void CircleNotExistTest() 
        {
            Assert.Throws<ArgumentException>(() => {
                Circle circle = new(-1);
            });
        }

        [Fact]
        public void RecalculateAreaTest() 
        {
            Circle circle = new(1);
            Assert.Equal(Math.PI, circle.Area);
            circle.Radius = 2;
            Assert.Equal(Math.PI * 4, circle.Area);
        }
    }
}
