namespace Mediator
{
    public abstract class Component
    {
        internal IMediator dialog;

        public void SetMediator(IMediator mediator)
        {
            dialog = mediator;
        }

        public void Click()
        {
            dialog.Notify(this, "click");
        }

        public void KeyPress()
        {
            dialog?.Notify(this, "keyPress");
        }
    }
}