using System.Drawing;

namespace Flyweight
{
    public class Tree
    {
        private readonly Point _position;
        private readonly TreeType _type;

        public Tree(Point position, TreeType type)
        {
            _position = position;
            _type = type;
        }

        public void Draw(Rectangle canvas)
        {
            _type.Draw(canvas, _position);
        }
    }
}