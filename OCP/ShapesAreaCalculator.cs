using System;

namespace OCP
{
    public class Circle
    {
        public double Radius { get; set; }
    }

    public class ShapesAreaCalculator
    {
        public static double Area(object[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    totalArea += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    totalArea += circle.Radius * circle.Radius * Math.PI;
                }

            }
            return totalArea;
        }
    }
}
