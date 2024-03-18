namespace Bridge
{
    public class LGRemoteControl : RemoteControlBase
    {
        public LGRemoteControl(IDevice device) : base(device)
        {
        }

        // LG remote control comes with the ability to mute the volumn
        public void Mute()
        {
            base.SetVolumn(0);
        }
    }
}