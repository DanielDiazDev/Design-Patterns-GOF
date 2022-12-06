using System.Collections.Generic;

namespace Composite
{
    class CompoundGraphic : IGraphic
    {
        public List<IGraphic> childrens = new List<IGraphic>();

        public IGraphic Add(IGraphic child)
        {
            childrens.Add(child);
            return this;
        }
        public IGraphic Remove(IGraphic child)
        {
            childrens.Remove(child);
            return this;
        }
        public IGraphic Move(int x, int y)
        {
            foreach (var children in childrens) children.Move(x, y);
            return this;
        }
        public IGraphic Draw()
        {
            foreach (var children in childrens) children.Draw();
            return this;
        }


    }
}