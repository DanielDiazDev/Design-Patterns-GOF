namespace Factory
{
    public abstract class Dialog
    {
        public void render()
        {
            IButton okButton = CreateButton();
            okButton.OnClick();
            okButton.render();
        }

        public abstract IButton CreateButton();
    }
}