namespace Adapter
{
  public class RoundPeg
    {
        private float radius;

        public RoundPeg() { }

        public RoundPeg(float radius)
        {
            this.radius = radius;
        }

        public float GetRadius()
        {
            return radius;
        }
    }
}