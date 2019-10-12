namespace OCP
{
    class ShapesAreaCalculator
    {
        public double Area(IShape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
                totalArea += shape.Area();
            return totalArea;
        }
    }
}
