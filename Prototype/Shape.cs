namespace Prototype
{
    abstract class Shape
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _color;

        protected Shape(int x, int y, string color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        protected Shape(Shape other) : this(other._x, other._y, other._color)
        {
        }

        public abstract Shape Clone();
    }
}