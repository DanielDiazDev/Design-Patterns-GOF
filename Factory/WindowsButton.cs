using System;

namespace Factory
{
    public class WindowsButton : IButton
    {
        public void OnClick() => Console.WriteLine("Windows btn");
        public void render() => Console.WriteLine("Windows render");
    }
}