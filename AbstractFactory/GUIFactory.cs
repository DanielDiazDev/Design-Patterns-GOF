namespace AbstractFactory
{
    interface GUIFactory 
    {
        Button CreateButton();
        CheckBox CreateCheckBox();
    }
}