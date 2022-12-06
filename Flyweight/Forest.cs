using System.Collections.Generic;
using System.Drawing;

namespace Flyweight
{
    public class Forest
    {
        private readonly List<Tree> _trees;

        public Forest()
        {
            _trees = new List<Tree>();
        }

        public void PlantTree(Point position, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(position, type);
            _trees.Add(tree);
        }

        public void Draw(Rectangle canvas)
        {
            foreach (var tree in _trees)
                tree.Draw(canvas);
        }
    }
}