using System;
using System.IO;

namespace OCP
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class RectanglesAreaCalculator
    {
        public static double Area(Rectangle[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Width * shape.Height;
            }
            return totalArea;
        }
    }
}