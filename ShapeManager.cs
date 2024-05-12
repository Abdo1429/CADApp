using System;
using System.Collections.Generic;

namespace CADApplication
{
    public class ShapeManager
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void ListAllShapes()
        {
            foreach (var shape in shapes)
            {
                shape.DisplayInfo();
            }
        }
    }
}
