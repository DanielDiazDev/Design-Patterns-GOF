using System;

namespace Factory
{
    public class HtmlButton : IButton
    {
        public void OnClick() => Console.WriteLine("Html btn");
        public void render() => Console.WriteLine("Html render");
    }
}