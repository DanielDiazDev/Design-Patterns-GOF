using System;

namespace Adapter
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg) : base()
        {
            this.peg = peg;
        }

        public float GetRadius()
        {
            return (float) (peg.GetWidth() * Math.Sqrt(2) / 2);
        }
    }
}