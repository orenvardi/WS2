using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        private string color;
        private bool isFilled;

        protected Shape()
        {
            Color = "green";
            IsFilled = true;
        }

        protected Shape(string color, bool isFilled)
        {
            Color = color;
            IsFilled = isFilled;
        }

        public string Color { get => color; set => color = value; }
        public bool IsFilled { get => isFilled; set => isFilled = value; }

        public abstract double Area();
        public abstract double Perimeter();
        public override /*new*/ string ToString()
        {
            return $"A Shape with color of {Color} and {(IsFilled ? "" : "not ")}filled";
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius = 1.0)
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool isFilled) : base(color, isFilled)
        {
            Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override /*new*/ string ToString()
        {
            return $"A Circle with radius={Radius}, which is a derived class of " + base.ToString();
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle(double width, double length = 1.0)
        {
            Width = width;
            Length = length;
        }

        public Rectangle(double width, double length, string color, bool isFilled) : base(color, isFilled)
        {
            Width = width;
            Length = length;
        }

        static Rectangle()
        {
            Console.WriteLine("Rectangle class initialized!");
        }

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        public override double Area()
        {
            return Width * Length;
        }

        public override double Perimeter()
        {
            return (2 * Width) + (2 * Length);
        }

        public override /*new*/ string ToString()
        {
            return $"A Rectangle with width={Width} and length={Length}, which is a Derived class of " + base.ToString();
        }
    }

    public class ComplexShape : Shape
    {
        private List<Shape> shapesList = new List<Shape>();

        public void Add(Shape shape)
        {
            shapesList.Add(shape);
        }
        public override double Area()
        {
            double sum = 0;
            foreach(Shape shape in shapesList)
            {
                sum += shape.Area();
            }
            return sum;
        }

        public override double Perimeter()
        {
            double sum = 0;
            foreach (Shape shape in shapesList)
            {
                sum += shape.Perimeter();
            }
            return sum;
        }
    }
}
