namespace ChainOfResponsibility
{
    public class Panel : Container
    {
        public string modalHelpText;

        public override void ShowHelp()
        {
            if (modalHelpText != null)
            {
                
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}