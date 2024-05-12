using System;

namespace CADApplication
{
    using System;

    namespace CADApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                ShapeManager shapeManager = new ShapeManager();

                // Adding sample shapes
                shapeManager.AddShape(new Rectangle(0, 0, 5, 10));
                shapeManager.AddShape(new Circle(2, 3, 7));
                shapeManager.AddShape(new Editbox(4, 6));

                // Listing all shapes
                shapeManager.ListAllShapes();
            }
        }
    }

    // Base class for all shapes
    public abstract class Shape
    {
        public abstract string Type { get; }
        public abstract double X { get; }
        public abstract double Y { get; }
        public abstract double Area();
        public abstract void DisplayInfo();
    }

    // Rectangle class
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
        }

        public override string Type => "Rectangle";
        public override double X { get; }
        public override double Y { get; }

        public override double Area()
        {
            return width * height;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}, X: {X}, Y: {Y}, Area: {Area()}");
        }
    }

    // Circle class
    public class Circle : Shape
    {
        private double radius;

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            this.radius = radius;
        }

        public override string Type => "Circle";
        public override double X { get; }
        public override double Y { get; }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}, X: {X}, Y: {Y}, Area: {Area()}");
        }
    }

    // Editbox class
    public class Editbox : Shape
    {
        // Assuming additional properties specific to Editbox are needed
        public Editbox(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string Type => "Editbox";
        public override double X { get; }
        public override double Y { get; }

        public override double Area()
        {
            // For simplicity, assuming Editbox has no area
            return 0;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}, X: {X}, Y: {Y}, Area: {Area()}");
        }
    }
}
