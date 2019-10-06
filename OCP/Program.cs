using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[] {
                new Rectangle {Width = 10, Height = 20 },
                new Rectangle{Width = 20, Height = 10 } };

            RectanglesAreaCalculator.Area(rectangles);


            object[] shapes = new object[] {
                new Rectangle {Width = 10, Height = 20 },
                new Circle { Radius = 20 } };

            ShapesAreaCalculator.Area(shapes);
        }
    }
}
