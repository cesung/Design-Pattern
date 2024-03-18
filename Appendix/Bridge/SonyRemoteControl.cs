using System.Threading.Channels;

namespace Bridge
{
    public class SonyRemoteControl : RemoteControlBase
    {
        private int m_previousChannel = -1;

        public SonyRemoteControl(IDevice device) : base(device)
        {
        }

        public void RecordCurrentChannel(int currnetChannel)
        {
            m_previousChannel = currnetChannel;
        }

        public override void SetChannelUp()
        {
            RecordCurrentChannel(base.GetChannel());
            base.SetChannelUp();
        }

        public override void SetChannelDown()
        {
            RecordCurrentChannel(base.GetChannel());
            base.SetChannelDown();
        }

        public override void SetChannel(int channel)
        {
            RecordCurrentChannel(base.GetChannel());
            base.SetChannel(channel);
        }

        // Sony remote control come with the ability to GoBack to previous visit channel
        public void GoBack()
        {
            if (m_previousChannel == -1)
            {
                return;
            }

            RecordCurrentChannel(base.GetChannel());
            base.SetChannel(m_previousChannel);
        }
    }
}