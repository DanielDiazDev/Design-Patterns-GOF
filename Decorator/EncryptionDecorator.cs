namespace Decorator
{
    class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource comp) : base(comp)
        {
        }
        public override string Operation()
        {
            return base.Operation();
        }
    }
}