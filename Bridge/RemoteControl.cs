using System;

namespace Bridge
{
    class RemoteControl
    {
        protected Device _device; 
        public RemoteControl(Device device)
        {
            _device = device;
        }
        public void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        public void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 10);
        }

        public void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        public void ChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
        }

        public void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        public void DisplayInfo()
        {

        }
    }
}