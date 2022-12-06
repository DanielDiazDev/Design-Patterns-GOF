using System;

namespace Adapter
{
    public class Program
    {
        public static void Main()
        {
            RoundHole hole = new RoundHole(5);
            RoundPeg rPeg = new RoundPeg(5);
            SquarePeg smallSQPeg = new SquarePeg(5);
            SquarePeg largeSQPeg = new SquarePeg(10);
            SquarePegAdapter smallSQPegAdapter = new SquarePegAdapter(smallSQPeg);
            SquarePegAdapter largeSQPegAdapter = new SquarePegAdapter(largeSQPeg);
            
        }
    }
}