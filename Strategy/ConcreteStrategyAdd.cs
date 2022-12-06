namespace Strategy
{
    public class ConcreteStrategyAdd : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}