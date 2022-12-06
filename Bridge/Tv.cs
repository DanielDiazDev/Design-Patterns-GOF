namespace Bridge
{
    class Tv : Device
    {
        private int Volume = 10;
        private bool Enabled = false;
        private int ChannelId = 0;
        public void Disable()
        {
            Enabled = false;
        }

        public void Enable()
        {
            Enabled = true;
        }

        public int GetChannel()
        {
            return ChannelId;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public bool IsEnabled()
        {
            return Enabled;
        }

        public void SetChannel(int channel)
        {
            ChannelId = channel;
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
        }
    }
}