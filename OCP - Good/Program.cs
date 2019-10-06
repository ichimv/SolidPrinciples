using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[] {
                new Rectangle {Width = 10, Height = 20 },
                new Circle { Radius = 20 } };

            ShapesAreaCalculator.Area(shapes);
        }
    }
}
