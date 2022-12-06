namespace Prototype
{
    class Rectangle : Shape
    {
        private readonly int _width;
        private readonly int _height;

        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
        {
            _width = width;
            _height = height;
        }

        public Rectangle(Rectangle other) : base(other)
        {
            _width = other._width;
            _height = other._height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}