namespace ChainOfResponsibility
{
    public abstract class UIComponent : ComponentWithContextualHelp
    {
        protected string tooltipText;

        
        public Container container; 
        
        public virtual void ShowHelp()
        {
            if (tooltipText != null)
            {
         
            }
            else
            {
                container.ShowHelp();
            }
        }
    }
}