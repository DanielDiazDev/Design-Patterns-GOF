namespace Strategy
{
    public class ConcreteStrategySubtract : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}