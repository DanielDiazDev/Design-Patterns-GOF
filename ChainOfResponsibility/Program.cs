using System;

namespace ChainOfResponsibility
{


    public class Program
    {
        public static void Main()
        {
            var dialog = new Dialog();
            dialog.wikiPageURL = "http://...";
            var panel = new Panel( );
            panel.modalHelpText = "TextHelp.";
            
            dialog.Add(panel);
            
            dialog.ShowHelp();
        }
    }
}