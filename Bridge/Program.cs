namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Device tv = new Tv();
            RemoteControl remoteControl = new RemoteControl(tv);

            remoteControl.TogglePower();
            remoteControl.ChannelUp();
            remoteControl.DisplayInfo();
            Device radio = new Radio();
            AdvancedRemoteControl advancedRemoteControl = new AdvancedRemoteControl(radio);

            advancedRemoteControl.TogglePower();
            advancedRemoteControl.Mute();
            advancedRemoteControl.DisplayInfo();
        }
    }
}