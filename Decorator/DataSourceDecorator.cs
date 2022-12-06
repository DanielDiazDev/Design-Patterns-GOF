namespace Decorator
{
    abstract class DataSourceDecorator : DataSource
    {
        protected DataSource _dataSource;

        public DataSourceDecorator(DataSource dataSource)
        {
            this._dataSource = dataSource;
        }

        public void SetComponent(DataSource dataSource)
        {
            this._dataSource = dataSource;
        }
        public override string Operation()
        {
            if (this._dataSource != null)
            {
                return this._dataSource.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}