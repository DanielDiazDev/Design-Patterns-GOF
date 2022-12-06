using System;

namespace Strategy
{
    public class ConcreteStrategyMultiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}