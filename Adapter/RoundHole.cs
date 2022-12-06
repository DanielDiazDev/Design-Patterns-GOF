namespace Adapter
{
    public class RoundHole
    {
        private float radius;
        public RoundHole(float radius)
        {
            this.radius = radius;
        }

        public float GetRadius()
        {
            return this.radius;
        }

        public bool Fits(RoundPeg peg)
        {
            return this.GetRadius() >= peg.GetRadius();
        }
    }
}