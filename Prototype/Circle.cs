namespace Prototype
{
    class Circle : Shape
    {
        private readonly int _radius;

        public Circle(int x, int y, string color, int radius) : base(x, y, color)
        {
            _radius = radius;
        }

        public Circle(Circle other) : base(other)
        {
            _radius = other._radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}