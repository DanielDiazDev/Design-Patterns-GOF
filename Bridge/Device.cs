namespace Bridge
{
    interface Device
    {
        void Enable();
        void Disable();
        bool IsEnabled();
        void SetVolume(int volume);
        int GetVolume();
        void SetChannel(int channel);
        int GetChannel();
    }
}