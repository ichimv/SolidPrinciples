using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Rectangle
    {
        private double itsWidth;
        private double itsHeight;

        public Rectangle(double w, double h)
        {
            SetWidth(w);
            SetHeight(h);
        }

        public virtual void SetWidth(double w) { itsWidth = w; }
        public virtual void SetHeight(double h) { itsHeight = h; }
        public double GetHeight() { return itsHeight; }
        public double GetWidth() { return itsWidth; }
    }

    class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }

        public override void SetWidth(double w)
        {
            base.SetWidth(w);
            base.SetHeight(w);
        }
        public override void SetHeight(double h)
        {
            base.SetHeight(h);
            base.SetWidth(h);
        }
    }
}
