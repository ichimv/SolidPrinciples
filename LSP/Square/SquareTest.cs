using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LSP
{
    class SquareTest
    {
        void ValidateRectangleArea(Rectangle r)
        {
            r.SetWidth(5);
            r.SetHeight(4);
            Debug.Assert((r.GetWidth() * r.GetHeight() == 20.0));
        }
    }
}
