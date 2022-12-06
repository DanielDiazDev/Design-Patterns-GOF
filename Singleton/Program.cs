namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Database foo = Database.getInstance();
            foo.query("SELECT * FROM users");
            Database bar = Database.getInstance();
            bar.query("SELECT * FROM admin");
        }
    }
}