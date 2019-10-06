namespace OCP
{
    class ShapesAreaCalculator
    {
        public static double Area(IShape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
                totalArea += shape.Area();
            return totalArea;
        }
    }
}
