using System;

namespace Decorator
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new FileDataSource();
            client.ClientCode(simple);
            Console.WriteLine();
            
            EncryptionDecorator decorator1 = new EncryptionDecorator(simple);
            CompressionDecorator decorator2 = new CompressionDecorator(decorator1);
            client.ClientCode(decorator2);
        }
    }
}