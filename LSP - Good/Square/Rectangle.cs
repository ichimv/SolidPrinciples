namespace LSP.Square
{
    class Rectangle : IShape
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

        public double Area()
        {
            return itsWidth * itsHeight;
        }
    }
}
