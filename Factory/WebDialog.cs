﻿namespace Factory
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton() => new HtmlButton();
    }
}