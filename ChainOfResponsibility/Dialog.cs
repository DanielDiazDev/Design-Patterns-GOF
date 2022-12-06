namespace ChainOfResponsibility
{
    public class Dialog : Container
    {
        public string wikiPageURL;

        public override void ShowHelp()
        {
            if (wikiPageURL != null)
            {
                
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}