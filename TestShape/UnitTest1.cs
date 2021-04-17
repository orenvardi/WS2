using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape;
using System;

namespace TestShape
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(3.5);
            Circle circle3 = new Circle(4, "red", false);

            Assert.AreEqual(circle1.Color, "green");
            Assert.AreEqual(circle1.IsFilled, true);
            Assert.AreEqual(circle1.Radius, 1.0);
            Assert.AreEqual(circle1.Area(), Math.PI * Math.Pow(1.0, 2.0));
            Assert.AreEqual(circle1.Perimeter(), 2 * Math.PI * 1.0);
            Assert.AreEqual(circle1.ToString(), "A Circle with radius=1, which is a derived class of A Shape with color of green and filled");

            Assert.AreEqual(circle2.Color, "green");
            Assert.AreEqual(circle2.IsFilled, true);
            Assert.AreEqual(circle2.Radius, 3.5);
            Assert.AreEqual(circle2.Area(), Math.PI * Math.Pow(3.5, 2.0));
            Assert.AreEqual(circle2.Perimeter(), 2 * Math.PI * 3.5);
            Assert.AreEqual(circle2.ToString(), "A Circle with radius=3.5, which is a derived class of A Shape with color of green and filled");

            Assert.AreEqual(circle3.Color, "red");
            Assert.AreEqual(circle3.IsFilled, false);
            Assert.AreEqual(circle3.Radius, 4.0);
            Assert.AreEqual(circle3.Area(), Math.PI * Math.Pow(4.0, 2.0));
            Assert.AreEqual(circle3.Perimeter(), 2 * Math.PI * 4.0);
            Assert.AreEqual(circle3.ToString(), "A Circle with radius=4, which is a derived class of A Shape with color of red and not filled");
        }

        public void TestRectangle()
        {
            Rectangle rectangle1 = new Rectangle(5);
            Rectangle rectangle2 = new Rectangle(2.5, 3.5);
            Rectangle rectangle3 = new Rectangle(4, 2, "red", false);

            //Assert.AreEqual(rectangle1.Color, "green");
            //Assert.AreEqual(rectangle1.IsFilled, true);
            //Assert.AreEqual(rectangle1.Radius, 1.0);
            //Assert.AreEqual(rectangle1.Area(), Math.PI * Math.Pow(1.0, 2.0));
            //Assert.AreEqual(rectangle1.Perimeter(), 2 * Math.PI * 1.0);
            //Console.WriteLine(rectangle1.ToString());
            //Assert.AreEqual(rectangle1.ToString(), "A Circle with radius=1, which is a derived class of A Shape with color of green and filled");

            //Assert.AreEqual(rectangle2.Color, "green");
            //Assert.AreEqual(rectangle2.IsFilled, true);
            //Assert.AreEqual(rectangle2.Radius, 3.5);

            //Assert.AreEqual(rectangle3.Color, "red");
            //Assert.AreEqual(rectangle3.IsFilled, false);
            //Assert.AreEqual(rectangle3.Radius, 4.0);
        }
    }
}
