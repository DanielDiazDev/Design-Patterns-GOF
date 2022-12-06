namespace AbstractFactory
{
    class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();    
        }

        public CheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}