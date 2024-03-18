using System.Runtime.InteropServices;
using System.Text;

namespace Bridge
{
    // The "abstraction" defines the interface for the "remote control"
    // part of the two class hierarchies. It maintains a reference
    // to an object of the "implementation" hierarchy and delegates
    // all of the real work to this object.
    public class RemoteControlBase
    {
        private IDevice m_device;

        public RemoteControlBase(IDevice device)
        {
            m_device = device;
        }

        public void TogglePower()
        {
            if (m_device.IsEnable())
            {
                m_device.Disable();
            }
            else
            {
                m_device.Enable();
            }
        }

        public bool GetDeviceState()
        {
            return m_device.IsEnable();
        }

        public virtual void SetVolumnUp()
        {
            m_device.SetVolumn(m_device.GetVolumn() + 1);
        }

        public virtual void SetVolumnDown()
        {
            m_device.SetVolumn(m_device.GetVolumn() - 1);
        }

        public virtual void SetVolumn(int volumn)
        {
            m_device.SetVolumn(volumn);
        }

        public virtual int GetVolumn()
        {
            return m_device.GetVolumn();
        }

        public virtual void SetChannelUp()
        {
            m_device.SetChannel(m_device.GetChannel() + 1);
        }

        public virtual void SetChannelDown()
        {
            m_device.SetChannel(m_device.GetChannel() - 1);
        }

        public virtual void SetChannel(int channel)
        {
            m_device.SetChannel(channel);
        }

        public virtual int GetChannel()
        {
            return m_device.GetChannel();
        }

        public virtual void ShowInfo()
        {
            var stringBuilder = new StringBuilder();

            var deviceState = GetDeviceState();
            var deviceStateString = deviceState ? "On" : "Off";
            stringBuilder.AppendLine($"The Device is {deviceStateString}");

            if (deviceState)
            {
                stringBuilder.AppendLine($"Current Volumn: {GetVolumn()}");
                stringBuilder.AppendLine($"Current Channel: {GetChannel()}");
            }

            var output = stringBuilder.ToString();
            stringBuilder.Remove(0, stringBuilder.Length);

            Console.WriteLine(output);

        }
    }
}