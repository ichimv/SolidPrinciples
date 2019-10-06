using System;

namespace OCP
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
