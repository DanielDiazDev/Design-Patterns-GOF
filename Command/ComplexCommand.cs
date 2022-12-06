using System;

namespace Command
{
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        
        private string _a;

        private string _b;
        
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public void Execute()
        {
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}