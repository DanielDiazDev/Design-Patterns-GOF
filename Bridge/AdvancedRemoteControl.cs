namespace Bridge
{
    class AdvancedRemoteControl : RemoteControl 
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }
}