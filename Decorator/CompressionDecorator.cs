namespace Decorator
{
    class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return base.Operation();
        }
    }
}