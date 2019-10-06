using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Square
{
    class Square : IShape
    {
        private double itsSide;

        public Square(double side)
        {
            SetSide(side);
        }
        public void SetSide(double side) {
            itsSide = side;
        }

        public double Area()
        {
            return itsSide * itsSide;
        }
    }
}
