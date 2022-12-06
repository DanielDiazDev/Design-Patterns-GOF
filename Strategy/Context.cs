namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public IStrategy Strategy { set { _strategy = value; } }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}