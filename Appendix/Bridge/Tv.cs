namespace Bridge
{
    public class Tv : IDevice
    {
        public bool State { get; set; } = false;

        public int Volumn { get; set; } = 5;

        public int Channel { get; set; } = 1;

        public bool IsEnable()
        {
            return State == true;
        }

        public void Enable()
        {
            State = true;
        }

        public void Disable()
        {
            State = false;
        }

        public int GetVolumn()
        {
            return Volumn;
        }

        public void SetVolumn(int volumn)
        {
            Volumn = volumn;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public void SetChannel(int channel)
        {
            Channel = channel;
        }
    }
}