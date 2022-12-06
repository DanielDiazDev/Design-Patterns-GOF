using System;

namespace Composite
{
    class Circle : Dot
    {
        public double Radius { get; set; }
        public Circle(int x, int y, int Radius) : base(x, y)
        {
            this.Radius = Radius;
        }
        public override IGraphic Draw()
        {
            return this;
        }
    }
}