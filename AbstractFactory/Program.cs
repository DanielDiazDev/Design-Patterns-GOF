using System;

namespace AbstractFactory
{
    class Program
    {
        const string OSType = "Windows"; 
        static GUIFactory _factory;
        
        static void Init()
        {
            if (OSType == "Windows")
            {
                _factory = new WinFactory();
            }
            else if (OSType == "Mac") 
            {
                _factory = new MacFactory();
            }
            else
                throw new Exception("Error! Sistema Operativo desconocido.");
        }
        static void Main(string[] args)
        {
            Init();
            Button button = _factory.CreateButton();
            button.Paint();
            CheckBox checkBox = _factory.CreateCheckBox();
            checkBox.Paint();

            Console.ReadLine();
        }
    }


}