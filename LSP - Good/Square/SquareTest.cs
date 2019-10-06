using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LSP.Square
{
    class RectangleTest
    {
        void ValidateRectangleArea()
        {
            IShape r = new Rectangle(5, 4);
            Debug.Assert((r.Area() == 20.0));
        }
    }

    class SquareTest
    {
        void ValidateSquareArea()
        {
            IShape s = new Square(4);
            Debug.Assert((s.Area() == 16.0));
        }
    }
}
