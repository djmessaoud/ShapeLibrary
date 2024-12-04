using ShapeLibrary.Shape.Implementation;

namespace Tests;

public class Tests
{

    public class CircleTests
    {
        [Test]
        public void Circle_Valid_Radius_Calc_Area()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.Area(), 0.01);
        }

        [Test]
        public void Circle_Negative_Radius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }

    public class TriangleTests
    {
        [Test]
        public void Triangle_Valid_Sides_Calc_Area()
        {
            var triangle = new Triangle(7, 10, 5);
            Assert.AreEqual(16.25, triangle.Area(), 0.01);
        }

        [Test]
        public void Triangle_Right_Triangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Test]
        public void Triangle_Invalid_Sides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }
    }
}