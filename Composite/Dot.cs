using System;

namespace Composite
{
    class Dot : IGraphic
    {

        private int _x { get; set; }
        private int _y { get; set; }

        public Dot(int x, int y)
        {
            _x = x;
            _y = y;
        }

        virtual public IGraphic Draw()
        {
            return this;
        }

        virtual public IGraphic Move(int x, int y)
        {
            _x = x;
            _y = y;
            return this;
        }
    }
}