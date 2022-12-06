using System;

namespace Command
{
    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;
        
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }
        
        public void DoSomethingImportant()
        {
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }
            
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}